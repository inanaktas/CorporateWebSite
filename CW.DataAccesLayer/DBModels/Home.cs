using System.ComponentModel.DataAnnotations;

namespace CW.DataAccesLayer.DBModels
{
    public class Home : BaseDBModel
    {

        [Required, MaxLength(50)]
        public string Title { get; set; }

        [Required, MaxLength(100)]
        public string ShortDescription { get; set; }

        [MaxLength(250)]
        public string? ImageUrl { get; set; }

    }
}
