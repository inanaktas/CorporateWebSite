namespace CW.EntitiesLayer.DataModels
{
    public class ProjectDataModel
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? ImageUrl1 { get; set; }
        public string? ImageUrl2 { get; set; }
        public string? ImageUrl3 { get; set; }
        public DateTime? CreatedDate { get; set; }
    }

}
