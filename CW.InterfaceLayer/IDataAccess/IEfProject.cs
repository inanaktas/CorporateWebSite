using CW.EntitiesLayer.DataModels;
using CW.EntitiesLayer.Parametres;

namespace CW.InterfaceLayer.IDataAccess
{
    public interface IEfProject
    {
        int Save(ProjectDataModel pModel);
        List<ProjectDataModel> Get(ProjectParametres param);
        int Delete(int pId);
        ProjectDataModel GetProjectDataModelWithId(int pId);

    }
}
