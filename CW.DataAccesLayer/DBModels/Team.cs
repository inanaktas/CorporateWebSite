using System.ComponentModel.DataAnnotations;

namespace CW.DataAccesLayer.DBModels
{
    public class Team : BaseDBModel
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, MaxLength(50)]
        public string Surname { get; set; }

        [Required, MaxLength(75)]
        public string Position { get; set; }

        [MaxLength(250)]
        public string? ImageUrl { get; set; }

        public bool IsActive { get; set; }
    }
}
