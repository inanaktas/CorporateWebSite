using CW.EntitiesLayer.DataModels;

namespace CW.InterfaceLayer.IDataAccess
{
    public interface IEfCareer
    {
        List<CareerDataModel> Get();
        int Delete(int pId);
        int Save(CareerDataModel pModel);
    }
}
