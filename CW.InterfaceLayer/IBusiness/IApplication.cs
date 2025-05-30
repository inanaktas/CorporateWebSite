using CW.EntitiesLayer.DataModels;

namespace CW.InterfaceLayer.IBusiness
{
    public interface IApplication
    {
        int SaveApplication(ApplicationDataModel pModel);
        List<ApplicationDataModel> GetAllApplications();
        int DeleteApplication(int pId);

    }
}
