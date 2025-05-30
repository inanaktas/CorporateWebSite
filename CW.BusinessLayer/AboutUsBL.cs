using CW.EntitiesLayer.DataModels;
using CW.InterfaceLayer.IBusiness;
using CW.InterfaceLayer.IDataAccess;

namespace CW.BusinessLayer
{
    public class AboutUsBL : IAboutUs
    {

        private readonly IEfAboutUs _iEfAboutUs;

        public AboutUsBL(IEfAboutUs IEfAboutUs)
        {
            _iEfAboutUs = IEfAboutUs;
        }
        public AboutUsDataModel GetAboutUsDataModel()
        {
            return _iEfAboutUs.Get();
        }

        public int SaveAboutUs(AboutUsDataModel pAboutUs)
        {

            return _iEfAboutUs.Save(pAboutUs);
        }

    }
}


