using CW.EntitiesLayer.DataModels;

namespace CW.InterfaceLayer.IDataAccess
{
	public interface IEfApplication
	{
		int Save(ApplicationDataModel pModel);
		List<ApplicationDataModel> Get();
		int Delete(int pId);
	}
}
