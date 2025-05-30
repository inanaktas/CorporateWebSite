using CW.EntitiesLayer.DataModels;
using CW.InterfaceLayer.IBusiness;
using CW.InterfaceLayer.IDataAccess;

namespace CW.BusinessLayer
{
    public class HomeBL : IHome
    {
        private readonly IEfHome _iEfHome;

        public HomeBL(IEfHome IEfHome)
        {
            _iEfHome = IEfHome;
        }

        public List<HomeDataModel> GetHomePageList()
        {
            return _iEfHome.Get();
        }

        public int DeleteHomePage(int pId)
        {
            return _iEfHome.Delete(pId);
        }

        public int SaveHomePage(HomeDataModel model)
        {
            return _iEfHome.Save(model);
        }
    }
}
