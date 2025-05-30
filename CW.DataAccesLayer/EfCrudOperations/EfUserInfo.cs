using CW.DataAccesLayer.DBContext;
using CW.EntitiesLayer.DataModels;
using CW.EntitiesLayer.Parametres;
using CW.InterfaceLayer.IDataAccess;

namespace CW.DataAccesLayer.EfCrudOperations
{
    public class EfUserInfo : IEfUserInfo
    {
        public UserInfoDataModel CheckUserInformation(SignInParametres pUserParam)
        {
            using (CorporateDBContext db = new CorporateDBContext())
            {
                UserInfoDataModel? model = db.UserInfos.Where(i => i.Password == pUserParam.Password
                && i.UserName == pUserParam.UserName).Select(i => new UserInfoDataModel
                {
                    Email = i.Email,
                    Name = i.Name,
                    UserId = i.Id,
                    Surname = i.Surname
                }).FirstOrDefault();

                return model;

            }
        }
    }
}
