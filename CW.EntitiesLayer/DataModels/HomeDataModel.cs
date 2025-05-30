namespace CW.EntitiesLayer.DataModels
{
    public class HomeDataModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string? ImageUrl { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }


    }
}
