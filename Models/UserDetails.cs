namespace TimeTracking_Ui.Models
{
    public class UserDetails
    {
        public int Id { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public string? Name { get; set; }
        public string? EmailAddress { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int RoleId { get; set; }
    }
}
