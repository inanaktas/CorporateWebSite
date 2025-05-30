using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CW.DataAccesLayer.DBModels
{
    public abstract class BaseDBModel
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int CreatedBy { get; set; }

        [Required]
        [ForeignKey("CreatedBy")]
        public UserInfo CreatedByUser { get; set; }

    }
}




