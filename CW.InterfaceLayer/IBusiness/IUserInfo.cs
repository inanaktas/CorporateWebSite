using CW.EntitiesLayer.DataModels;
using CW.EntitiesLayer.Parametres;

namespace CW.InterfaceLayer.IBusiness
{
    public interface IUserInfo
    {
        UserInfoDataModel CheckUserBL(SignInParametres pUser);
    }
}
