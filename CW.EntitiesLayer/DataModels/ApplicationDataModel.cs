namespace CW.EntitiesLayer.DataModels
{
    public class ApplicationDataModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string ShortDescription { get; set; }
        public int ExperienceId { get; set; }
        public int JobCategoryId { get; set; }
        public List<int> SkillIds { get; set; } // Seçilen skill ID'leri

        //Listeleme için ek alanlar
        public string Experience { get; set; }
        public string JobCategory { get; set; }
        public List<string> Skills { get; set; }

    }
}
