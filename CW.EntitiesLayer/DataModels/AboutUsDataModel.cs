namespace CW.EntitiesLayer.DataModels
{
    public class AboutUsDataModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string? ImageUrl { get; set; }
        public int CreatedBy { get; set; }
        public string Vision { get; set; }
        public string Mission { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}
