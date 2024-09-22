namespace JPBank.Models.Entities
{
    public class SignupEntity
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required int UserType { get; set; }
        public int IsActive { get; set; }
    }
}
