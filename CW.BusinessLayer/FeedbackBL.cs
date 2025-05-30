using CW.EntitiesLayer.DataModels;
using CW.InterfaceLayer.IBusiness;
using CW.InterfaceLayer.IDataAccess;

namespace CW.BusinessLayer
{
    public class FeedbackBL : IFeedback
    {

        private readonly IEfFeedback _iEfFeedback;


        public FeedbackBL(IEfFeedback IEfFeedback)
        {
            _iEfFeedback = IEfFeedback;
        }
        public int SaveFeedback(FeedbackDataModel pModel)
        {
            return (_iEfFeedback.Save(pModel));
        }

        public List<FeedbackDataModel> GetAllFeedbacks()
        {
            return (_iEfFeedback.Get());
        }

        public int DeleteFeedback(int pId)
        {
            return _iEfFeedback.Delete(pId);
        }

        public int UpdateFeedback(FeedbackUpdateDataModel pModel)
        {
            return (_iEfFeedback.Update(pModel));
        }


    }
}
