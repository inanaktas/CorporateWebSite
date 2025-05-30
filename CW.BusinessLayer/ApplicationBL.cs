using CW.EntitiesLayer.DataModels;
using CW.InterfaceLayer.IBusiness;
using CW.InterfaceLayer.IDataAccess;

namespace CW.BusinessLayer
{
	public class ApplicationBL : IApplication
	{

		private readonly IEfApplication _iEfApplication;

		public ApplicationBL(IEfApplication IEfApplication)
		{
			_iEfApplication = IEfApplication;
		}

		public int SaveApplication(ApplicationDataModel pModel)
		{
			return (_iEfApplication.Save(pModel));
		}

		public List<ApplicationDataModel> GetAllApplications()
		{
			return (_iEfApplication.Get());
		}

		public int DeleteApplication(int pId)
		{
			return _iEfApplication.Delete(pId);
		}

	}
}
