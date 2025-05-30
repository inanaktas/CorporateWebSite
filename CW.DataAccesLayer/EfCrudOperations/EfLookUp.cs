using CW.DataAccesLayer.DBContext;
using CW.DataAccesLayer.DBModels;

namespace CW.DataAccesLayer.EfCrudOperations
{
    public class EfLookUp
    {

        //DB ye hazır kaydedilmiş application ile many to many ilişkili veriler. view kısmında liste şeklinde iş başvurusunda çıkacak
        //sadece bu amaçla görevi var ayrı bir view oluşturmuyor
        public List<Skills> GetSkills()
        {
            using (CorporateDBContext db = new CorporateDBContext())
            {
                return db.Skills.ToList();

            }
        }

        public List<Experience> GetExperiences()
        {
            using (CorporateDBContext db = new CorporateDBContext())
            {
                return db.Experiences.ToList();
            }
        }

        public List<JobCategory> GetJobCategories()
        {
            using (CorporateDBContext db = new CorporateDBContext())
            {
                return db.JobCategories.ToList();
            }
        }


    }
}
