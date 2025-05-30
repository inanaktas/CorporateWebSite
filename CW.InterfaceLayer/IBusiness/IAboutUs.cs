using CW.EntitiesLayer.DataModels;

namespace CW.InterfaceLayer.IBusiness
{
	public interface IAboutUs
	{
		AboutUsDataModel GetAboutUsDataModel();

		int SaveAboutUs(AboutUsDataModel pAboutUs);

	}
}
