using CW.EntitiesLayer.DataModels;

namespace CW.InterfaceLayer.IBusiness
{
    public interface ICareer
    {
        List<CareerDataModel> GetCareerList();
        int DeleteCareer(int pId);
        int SaveCareer(CareerDataModel model);
    }
}
