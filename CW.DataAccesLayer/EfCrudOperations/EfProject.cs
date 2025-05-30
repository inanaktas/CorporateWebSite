using CW.DataAccesLayer.DBContext;
using CW.DataAccesLayer.DBModels;
using CW.EntitiesLayer.DataModels;
using CW.EntitiesLayer.Parametres;
using CW.InterfaceLayer.IDataAccess;

namespace CW.DataAccesLayer.EfCrudOperations
{
    public class EfProject : IEfProject
    {

        public int Save(ProjectDataModel pModel)
        {
            Project model = new Project()
            {
                Id = pModel.Id,
                Description = pModel.Description,
                ShortDescription = pModel.ShortDescription,
                CreatedBy = pModel.CreatedBy,
                EndDate = pModel.EndDate,
                StartDate = pModel.StartDate,
                ImageUrl1 = pModel.ImageUrl1,
                ImageUrl2 = pModel.ImageUrl2,
                ImageUrl3 = pModel.ImageUrl3,
                Title = pModel.Title,
                CreatedDate = pModel.CreatedDate ?? DateTime.Now
            };

            using (CorporateDBContext db = new CorporateDBContext())
            {
                if (pModel.Id > 0)//güncelleme
                {
                    model.UpdateDate = DateTime.Now;
                    db.Projects.Update(model);
                }
                else // sıfırdan ekleme
                {
                    db.Projects.Add(model);
                }

                return db.SaveChanges();
            }
        }

        public List<ProjectDataModel> Get(ProjectParametres param)
        {
            using (CorporateDBContext db = new CorporateDBContext())
            {
                // Sorgu için gerekli koşulları dinamik olarak oluşturulması
                var query = db.Projects.AsQueryable();

                // Başlık sorgusu
                if (!string.IsNullOrEmpty(param.Title))
                {
                    query = query.Where(i => i.Title.Contains(param.Title));
                }

                // Açıklama sorgusu
                if (!string.IsNullOrEmpty(param.Description))
                {
                    query = query.Where(i => i.Description.Contains(param.Description));
                }

                // Başlangıç tarihi sorgusu
                if (param.StartDate.HasValue)
                {
                    query = query.Where(i => i.StartDate >= param.StartDate.Value);
                }

                // Bitiş tarihi sorgusu 
                if (param.EndDate.HasValue)
                {
                    query = query.Where(i => i.EndDate <= param.EndDate.Value);
                }

                // Sonuçları seçme
                var projectList = query.Select(i => new ProjectDataModel
                {
                    Id = i.Id,
                    CreatedBy = i.CreatedBy,
                    EndDate = i.EndDate,
                    Description = i.Description,
                    ImageUrl1 = i.ImageUrl1,
                    ImageUrl2 = i.ImageUrl2,
                    ImageUrl3 = i.ImageUrl3,
                    ShortDescription = i.ShortDescription,
                    StartDate = i.StartDate,
                    Title = i.Title,
                    CreatedDate = i.CreatedDate,
                }).ToList();

                return projectList;
            }
        }

        public int Delete(int pId)
        {
            using (CorporateDBContext db = new CorporateDBContext())
            {
                Project model = db.Projects.Where(p => p.Id == pId).FirstOrDefault();

                if (model != null)
                {
                    db.Projects.Remove(model);
                    return db.SaveChanges();
                }

                return 0;
            }
        }

        public Project GetProjectWithId(int pId)
        {
            using (CorporateDBContext db = new CorporateDBContext())
            {
                return db.Projects.Where(i => i.Id == pId).FirstOrDefault();
            }
        }

        public ProjectDataModel GetProjectDataModelWithId(int pId)
        {
            using (CorporateDBContext db = new CorporateDBContext())
            {
                return db.Projects.Where(i => i.Id == pId).Select(i => new ProjectDataModel
                {
                    StartDate = i.StartDate,
                    EndDate = i.EndDate,
                    CreatedBy = i.CreatedBy,
                    Id = i.Id,
                    Description = i.Description,
                    ImageUrl1 = i.ImageUrl1,
                    ImageUrl2 = i.ImageUrl2,
                    ImageUrl3 = i.ImageUrl3,
                    ShortDescription = i.ShortDescription,
                    Title = i.Title,
                    CreatedDate = i.CreatedDate,

                }).FirstOrDefault();
            }
        }


    }
}



