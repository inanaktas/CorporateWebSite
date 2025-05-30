namespace CW.EntitiesLayer.DataModels
{
    public class FeedbackDataModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public bool? IsRead { get; set; }
        public bool? IsPending { get; set; }
    }
}
