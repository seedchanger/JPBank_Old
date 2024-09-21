namespace JPBank.Models
{
    public class UserEntity
    {
        public int UserId { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public int UserType { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
