namespace CW.DataAccesLayer.DBModels
{
    public class Experience
    {
        public int Id { get; set; }
        public string Year { get; set; }

        // One-to-Many ilişkisi (opsiyonel)
        public ICollection<Application> Applications { get; set; }
    }
}
