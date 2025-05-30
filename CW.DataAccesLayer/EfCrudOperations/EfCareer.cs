using CW.DataAccesLayer.DBContext;
using CW.DataAccesLayer.DBModels;
using CW.EntitiesLayer.DataModels;
using CW.InterfaceLayer.IDataAccess;

namespace CW.DataAccesLayer.EfCrudOperations
{
    public class EfCareer : IEfCareer
    {

        public List<CareerDataModel> Get()
        {
            using (CorporateDBContext db = new CorporateDBContext())
            {
                var query = db.Careers.AsQueryable();

                var careerContentList = query.Select(i => new CareerDataModel
                {
                    Id = i.Id,
                    Title = i.Title,
                    ShortDescription = i.ShortDescription,
                    ImageUrl = i.ImageUrl,
                    CreatedBy = i.CreatedBy,
                    CreatedDate = i.CreatedDate,
                }).ToList();

                return careerContentList;
            }
        }

        public int Delete(int pId)
        {
            using (CorporateDBContext db = new CorporateDBContext())
            {
                Career model = db.Careers.Where(p => p.Id == pId).FirstOrDefault();
                if (model != null)
                {
                    db.Careers.Remove(model);
                    return db.SaveChanges();
                }

                return 0;

            }




        }

        public int Save(CareerDataModel pModel)
        {
            Career model = new Career
            {
                Id = pModel.Id,
                Title = pModel.Title,
                ShortDescription = pModel.ShortDescription,
                ImageUrl = pModel.ImageUrl,
                CreatedBy = pModel.CreatedBy
            };

            using (CorporateDBContext db = new CorporateDBContext())
            {
                if (pModel.Id > 0)
                {
                    model.UpdateDate = DateTime.Now;
                    db.Careers.Update(model);
                }
                else
                {
                    model.CreatedDate = pModel.CreatedDate.Value;
                    db.Careers.Add(model);
                }

                return db.SaveChanges();

            }

        }



    }
}
