using CW.EntitiesLayer.DataModels;
using CW.EntitiesLayer.Parametres;

namespace CW.InterfaceLayer.IDataAccess
{
    public interface IEfUserInfo
    {
        UserInfoDataModel CheckUserInformation(SignInParametres pUserParam);
    }
}
