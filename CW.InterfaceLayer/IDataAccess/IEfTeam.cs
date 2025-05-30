using CW.EntitiesLayer.DataModels;

namespace CW.InterfaceLayer.IDataAccess
{
    public interface IEfTeam
    {
        List<TeamDataModel> Get();
        int Delete(int pId);
        int Save(TeamDataModel pModel);

    }
}
