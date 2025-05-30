using CW.DataAccesLayer.DBContext;
using CW.DataAccesLayer.DBModels;
using CW.EntitiesLayer.DataModels;
using CW.InterfaceLayer.IDataAccess;
using Microsoft.EntityFrameworkCore;

namespace CW.DataAccesLayer.EfCrudOperations
{
	public class EfApplication : IEfApplication
	{

		public int Save(ApplicationDataModel pModel)
		{
			//ApplicationSkills ara tablodan select ile ilgili id nin alınması
			Application model = new Application()
			{
				Id = pModel.Id,
				Name = pModel.Name,
				Surname = pModel.Surname,
				Email = pModel.Email,
				ShortDescription = pModel.ShortDescription,
				JobCategoryId = pModel.JobCategoryId,
				ExperienceId = pModel.ExperienceId,
				ApplicationSkills = pModel.SkillIds.Select(skillId => new ApplicationSkill
				{
					SkillId = skillId,

				}).ToList()
			};

			using (CorporateDBContext db = new CorporateDBContext())
			{
				db.Applications.Add(model);
				return db.SaveChanges();
			}

		}

		public List<ApplicationDataModel> Get()
		{
			//many to many tablo için LINQ Sorgusu
			using (CorporateDBContext db = new CorporateDBContext())
			{
				return db.Applications.Include(i => i.Experience).Include(i => i.JobCategory)
					.Include(i => i.ApplicationSkills)
					.ThenInclude(i => i.Skill)
					.Select(i => new ApplicationDataModel
					{
						Id = i.Id,
						Name = i.Name,
						Surname = i.Surname,
						Email = i.Email,
						ShortDescription = i.ShortDescription,
						Experience = i.Experience.Year,
						JobCategory = i.JobCategory.JobName,
						Skills = i.ApplicationSkills.Select(i => i.Skill.SkillName).ToList()

					}).ToList();
			}
		}

		public int Delete(int pId)
		{

			// admin tarafından başvurunun silinmesi
			using (CorporateDBContext db = new CorporateDBContext())
			{
				Application model = db.Applications.Where(i => i.Id == pId).FirstOrDefault();
				if (model != null)
				{
					db.Applications.Remove(model);
					return db.SaveChanges();
				}

				return 0;
			}
		}
	}
}
