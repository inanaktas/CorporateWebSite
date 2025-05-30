using System.ComponentModel.DataAnnotations;

namespace CW.DataAccesLayer.DBModels
{
    public class Feedback
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, MaxLength(50)]
        public string Surname { get; set; }

        [Required, MaxLength(50)]
        public string Email { get; set; }

        [Required, MaxLength(50)]
        public string PhoneNumber { get; set; }

        [Required, MaxLength(1000)]
        public string Message { get; set; }

        public bool IsRead { get; set; } // Okundu durumu

        public bool IsPending { get; set; } // İşlem yapıldı mı

    }
}
