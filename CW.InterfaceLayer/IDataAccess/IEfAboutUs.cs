using CW.EntitiesLayer.DataModels;

namespace CW.InterfaceLayer.IDataAccess
{
    public interface IEfAboutUs
    {
        AboutUsDataModel Get();
        int Save(AboutUsDataModel pAboutUs);
    }
}
