namespace CW.DataAccesLayer.DBModels
{
	public class ApplicationSkill
	{
		//many to many ilişki için ara tablo
		public int ApplicationId { get; set; }
		public Application Application { get; set; }

		public int SkillId { get; set; }
		public Skills Skill { get; set; }

	}
}
