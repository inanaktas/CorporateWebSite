using CW.EntitiesLayer.DataModels;
using CW.EntitiesLayer.Parametres;

namespace CW.InterfaceLayer.IBusiness
{
    public interface IProject
    {
        int SaveProject(ProjectDataModel pModel);
        int DeleteProject(int pId);
        List<ProjectDataModel> GetProjectList(ProjectParametres param);
        ProjectDataModel GetProjectDataModel(int pId);

    }
}
