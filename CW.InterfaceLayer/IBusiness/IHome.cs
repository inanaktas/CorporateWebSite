using CW.EntitiesLayer.DataModels;

namespace CW.InterfaceLayer.IBusiness
{
	public interface IHome
	{
		int DeleteHomePage(int pId);

		List<HomeDataModel> GetHomePageList();

		int SaveHomePage(HomeDataModel model);
	}
}
