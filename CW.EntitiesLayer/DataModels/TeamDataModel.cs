namespace CW.EntitiesLayer.DataModels
{
    public class TeamDataModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public int CreatedBy { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool IsActive { get; set; }


    }
}
