using CW.EntitiesLayer.DataModels;
using CW.InterfaceLayer.IBusiness;
using CW.InterfaceLayer.IDataAccess;

namespace CW.BusinessLayer
{
    public class TeamBL : ITeam
    {
        private readonly IEfTeam _iEfTeam;

        public TeamBL(IEfTeam IEfTeam)
        {
            _iEfTeam = IEfTeam;
        }

        public List<TeamDataModel> GetTeamList()
        {
            return _iEfTeam.Get();
        }

        public int DeleteTeam(int pId)
        {
            return _iEfTeam.Delete(pId);
        }

        public int SaveTeam(TeamDataModel model)
        {
            return _iEfTeam.Save(model);
        }
    }
}
