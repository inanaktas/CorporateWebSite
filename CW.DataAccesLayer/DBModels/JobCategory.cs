namespace CW.DataAccesLayer.DBModels
{
    public class JobCategory
    {
        public int Id { get; set; }
        public string JobName { get; set; }

        // One-to-Many ilişkisi
        public ICollection<Application> Applications { get; set; }
    }
}
