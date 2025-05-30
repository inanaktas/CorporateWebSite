using System.ComponentModel.DataAnnotations;

namespace CW.DataAccesLayer.DBModels
{
	public class Project : BaseDBModel
	{
		[Required, MaxLength(100)]
		public string Title { get; set; }

		[Required, MaxLength(1000)]
		public string ShortDescription { get; set; }

		[Required, MaxLength(4000)]
		public string Description { get; set; }

		public DateTime? StartDate { get; set; }

		public DateTime? EndDate { get; set; }

		public string? ImageUrl1 { get; set; }

		public string? ImageUrl2 { get; set; }

		public string? ImageUrl3 { get; set; }


	}
}


