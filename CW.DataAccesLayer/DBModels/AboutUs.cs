using System.ComponentModel.DataAnnotations;

namespace CW.DataAccesLayer.DBModels
{
	public class AboutUs : BaseDBModel
	{
		[Required, MaxLength(200)]
		public string Title { get; set; }

		[Required, MaxLength(1000)]
		public string ShortDescription { get; set; }

		[Required, MaxLength(4000)]
		public string Description { get; set; }

		[MaxLength(250)]
		public string? ImageUrl { get; set; }

		[Required, MaxLength(250)]
		public string Vision { get; set; }

		[Required, MaxLength(250)]
		public string Mission { get; set; }

	}
}
