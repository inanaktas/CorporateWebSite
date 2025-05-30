using CW.DataAccesLayer.DBModels;
using CW.DataAccesLayer.EfCrudOperations;

namespace CW.BusinessLayer
{
    public class LookUpBL
    {
        EfLookUp ef = new EfLookUp();

        public List<Skills> GetSkills()
        {
            return ef.GetSkills();
        }

        public List<Experience> GetExperiences()
        {
            return ef.GetExperiences();
        }

        public List<JobCategory> GetJobCategories()
        {
            return ef.GetJobCategories();
        }
    }
}
