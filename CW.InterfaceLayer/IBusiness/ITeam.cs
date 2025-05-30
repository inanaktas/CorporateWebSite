using CW.EntitiesLayer.DataModels;

namespace CW.InterfaceLayer.IBusiness
{
    public interface ITeam
    {
        List<TeamDataModel> GetTeamList();
        int DeleteTeam(int pId);
        int SaveTeam(TeamDataModel model);

    }
}
