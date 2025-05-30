using CW.DataAccesLayer.DBContext;
using CW.DataAccesLayer.DBModels;
using CW.EntitiesLayer.DataModels;
using CW.InterfaceLayer.IDataAccess;

namespace CW.DataAccesLayer.EfCrudOperations
{
    public class EfAboutUs : IEfAboutUs
    {
        public AboutUsDataModel Get()
        {
            using (CorporateDBContext db = new CorporateDBContext())
            {
                AboutUsDataModel? model = db.AboutUs.Select(i => new AboutUsDataModel
                {
                    Id = i.Id,
                    Description = i.Description,
                    ImageUrl = i.ImageUrl,
                    ShortDescription = i.ShortDescription,
                    Title = i.Title,
                    CreatedBy = i.CreatedBy,
                    Mission = i.Mission,
                    Vision = i.Vision
                }).FirstOrDefault();

                return model;
            }
        }

        public int Save(AboutUsDataModel pAboutUs)
        {
            AboutUs model = new AboutUs
            {
                Id = pAboutUs.Id,
                ImageUrl = pAboutUs.ImageUrl,
                Title = pAboutUs.Title,
                Description = pAboutUs.Description,
                ShortDescription = pAboutUs.ShortDescription,
                CreatedBy = pAboutUs.CreatedBy,
                Vision = pAboutUs.Vision,
                Mission = pAboutUs.Mission,
            };

            using (CorporateDBContext db = new CorporateDBContext())
            {

                if (pAboutUs.Id > 0)
                {
                    model.UpdateDate = DateTime.Now;
                    db.AboutUs.Update(model);
                }
                else
                {
                    model.CreatedDate = pAboutUs.CreatedDate.Value;
                    db.AboutUs.Add(model);
                }

                return db.SaveChanges();
            }
        }

    }
}
