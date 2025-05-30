using CW.EntitiesLayer.DataModels;
using CW.EntitiesLayer.Parametres;
using CW.InterfaceLayer.IBusiness;
using CW.InterfaceLayer.IDataAccess;

namespace CW.BusinessLayer
{
    public class ProjectBL : IProject
    {
        private readonly IEfProject _iEfProject;

        public ProjectBL(IEfProject IEfProject)
        {
            _iEfProject = IEfProject;
        }

        public int SaveProject(ProjectDataModel pModel)
        {
            return _iEfProject.Save(pModel);
        }

        public int DeleteProject(int pId)
        {
            return _iEfProject.Delete(pId);
        }

        public List<ProjectDataModel> GetProjectList(ProjectParametres param)
        {
            return _iEfProject.Get(param);
        }

        public ProjectDataModel GetProjectDataModel(int pId)
        {
            return _iEfProject.GetProjectDataModelWithId(pId);
        }

    }
}
