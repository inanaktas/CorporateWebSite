using CW.DataAccesLayer.DBContext;
using CW.DataAccesLayer.DBModels;
using CW.EntitiesLayer.DataModels;
using CW.InterfaceLayer.IDataAccess;

namespace CW.DataAccesLayer.EfCrudOperations
{
    public class EfHome : IEfHome
    {

        public List<HomeDataModel> Get()
        {
            using (CorporateDBContext db = new CorporateDBContext())
            {
                var query = db.Homes.AsQueryable();

                var homeContentList = query.Select(i => new HomeDataModel
                {
                    Id = i.Id,
                    Title = i.Title,
                    CreatedBy = i.CreatedBy,
                    ShortDescription = i.ShortDescription,
                    ImageUrl = i.ImageUrl,
                    CreatedDate = i.CreatedDate,
                }).ToList();

                return homeContentList;
            }

        }

        public int Delete(int pId)
        {

            using (CorporateDBContext db = new CorporateDBContext())
            {
                Home model = db.Homes.Where(p => p.Id == pId).FirstOrDefault();

                if (model != null)
                {
                    db.Homes.Remove(model);
                    return db.SaveChanges();
                }

                return 0;
            }
        }

        public int Save(HomeDataModel pModel)
        {
            Home model = new Home()
            {
                Id = pModel.Id,
                Title = pModel.Title,
                CreatedBy = pModel.CreatedBy,
                ShortDescription = pModel.ShortDescription,
                ImageUrl = pModel.ImageUrl,
            };
            using (CorporateDBContext db = new CorporateDBContext())
            {
                if (pModel.Id > 0)
                {
                    model.UpdateDate = DateTime.Now;
                    db.Homes.Update(model);
                }
                else
                {
                    model.CreatedDate = pModel.CreatedDate.Value;
                    db.Homes.Add(model);
                }

                return db.SaveChanges();
            }


        }

    }
}
