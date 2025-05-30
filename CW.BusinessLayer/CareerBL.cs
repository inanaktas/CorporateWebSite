using CW.EntitiesLayer.DataModels;
using CW.InterfaceLayer.IBusiness;
using CW.InterfaceLayer.IDataAccess;

namespace CW.BusinessLayer
{
    public class CareerBL : ICareer
    {

        private readonly IEfCareer _iEfCareer;

        public CareerBL(IEfCareer IEfCareer)
        {
            _iEfCareer = IEfCareer;
        }

        public List<CareerDataModel> GetCareerList()
        {
            return (_iEfCareer.Get());
        }

        public int DeleteCareer(int pId)
        {
            return (_iEfCareer.Delete(pId));
        }

        public int SaveCareer(CareerDataModel model)
        {
            return (_iEfCareer.Save(model));
        }

    }
}
