using CW.DataAccesLayer.DBContext;
using CW.DataAccesLayer.DBModels;
using CW.EntitiesLayer.DataModels;
using CW.InterfaceLayer.IDataAccess;

namespace CW.DataAccesLayer.EfCrudOperations
{
    public class EfTeam : IEfTeam
    {
        public List<TeamDataModel> Get()
        {
            using (CorporateDBContext dBContext = new CorporateDBContext())
            {
                var query = dBContext.Teams.AsQueryable();

                var teamContentList = query.Select(i => new TeamDataModel
                {
                    Id = i.Id,
                    Name = i.Name,
                    Surname = i.Surname,
                    CreatedBy = i.CreatedBy,
                    CreatedDate = i.CreatedDate,
                    ImageUrl = i.ImageUrl,
                    Position = i.Position,
                    IsActive = i.IsActive


                }).ToList();

                return teamContentList;
            }
        }


        public int Delete(int pId)
        {
            using (CorporateDBContext db = new CorporateDBContext())
            {
                Team model = db.Teams.Where(p => p.Id == pId).FirstOrDefault();

                if (model != null)
                {
                    db.Teams.Remove(model);
                    return db.SaveChanges();
                }

                return 0;
            }
        }


        public int Save(TeamDataModel pModel)
        {
            Team model = new Team()
            {
                Id = pModel.Id,
                Name = pModel.Name,
                Surname = pModel.Surname,
                CreatedBy = pModel.CreatedBy,
                Position = pModel.Position,
                ImageUrl = pModel.ImageUrl,
                IsActive = pModel.IsActive,
                CreatedDate = pModel.CreatedDate ?? DateTime.Now
            };
            using (CorporateDBContext db = new CorporateDBContext())
            {
                if (pModel.Id > 0)
                {
                    model.UpdateDate = DateTime.Now;
                    db.Teams.Update(model);
                }
                else
                {
                    db.Teams.Add(model);
                }

                return db.SaveChanges();
            }
        }
    }
}
