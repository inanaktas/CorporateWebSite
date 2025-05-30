using CW.EntitiesLayer.DataModels;

namespace CW.InterfaceLayer.IDataAccess
{
    public interface IEfFeedback
    {

        int Save(FeedbackDataModel pModel);
        List<FeedbackDataModel> Get();
        int Delete(int pId);
        int Update(FeedbackUpdateDataModel pModel);
    }
}
