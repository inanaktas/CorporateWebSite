using CW.EntitiesLayer.DataModels;

namespace CW.InterfaceLayer.IBusiness
{
    public interface IFeedback
    {

        int SaveFeedback(FeedbackDataModel pModel);
        List<FeedbackDataModel> GetAllFeedbacks();
        int DeleteFeedback(int pId);
        int UpdateFeedback(FeedbackUpdateDataModel pModel);


    }
}
