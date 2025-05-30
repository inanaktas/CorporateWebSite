using System.ComponentModel.DataAnnotations;

namespace CW.DataAccesLayer.DBModels
{
    public class UserInfo
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required, MaxLength(50)]
        public string Surname { get; set; }

        [Required, MaxLength(50)]
        public string UserName { get; set; }

        [Required, MaxLength(50)]
        public string Password { get; set; }

        [Required, MaxLength(50)]
        public string Email { get; set; }

        //one to many ilişkiler
        public ICollection<AboutUs> AboutUs { get; set; } = new List<AboutUs>();
        public ICollection<Project> Projects { get; set; } = new List<Project>();

    }
}
