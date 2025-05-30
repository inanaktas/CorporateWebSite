using CW.EntitiesLayer.DataModels;

namespace CW.InterfaceLayer.IDataAccess
{
    public interface IEfHome
    {

        int Delete(int pId);

        List<HomeDataModel> Get();

        int Save(HomeDataModel pModel);


    }
}
