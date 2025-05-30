using System.ComponentModel.DataAnnotations;

namespace CW.DataAccesLayer.DBModels
{
    public class Application
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, MaxLength(50)]
        public string Surname { get; set; }

        [MaxLength(1000)]
        public string? ShortDescription { get; set; }

        [Required, MaxLength(50)]
        public string Email { get; set; }

        //Many-to-One - Her başvuru bir experience'e sahip
        public int ExperienceId { get; set; }
        public Experience Experience { get; set; }

        //Many-to-One - Her başvuru bir JobCategory'e sahip
        public int JobCategoryId { get; set; }
        public JobCategory JobCategory { get; set; }

        // Many-to-Many - Bir başvurunun birden fazla skill'i olabilir
        public ICollection<ApplicationSkill> ApplicationSkills { get; set; }

    }
}
