namespace CW.DataAccesLayer.DBModels
{
	public class Skills
	{

		// İş başvurusu application ve bilgisayar bilgisi skills ilişkili tablo
		public int Id { get; set; }
		public string SkillName { get; set; }

		// Many-to-Many için ara tablo ilişkisi
		public ICollection<ApplicationSkill> ApplicationSkills { get; set; }
	}
}
