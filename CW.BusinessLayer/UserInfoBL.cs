using CW.EntitiesLayer.DataModels;
using CW.EntitiesLayer.Parametres;
using CW.InterfaceLayer.IBusiness;
using CW.InterfaceLayer.IDataAccess;

namespace CW.BusinessLayer
{
    public class UserInfoBL : IUserInfo
    {
        private readonly IEfUserInfo _iEfUserInfo;
        public UserInfoBL(IEfUserInfo IEfUserInfo)
        {
            _iEfUserInfo = IEfUserInfo;
        }
        public UserInfoDataModel CheckUserBL(SignInParametres pUser)
        {
            return _iEfUserInfo.CheckUserInformation(pUser);
        }

    }
}
