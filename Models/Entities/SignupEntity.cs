using System.ComponentModel.DataAnnotations;

namespace JPBank.Models.Entities
{
    public class SignupEntity
    {
        [Required(ErrorMessage ="Please enter name")]
        public required string Name { get; set; }
        public required string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Password and Confirm Password are different")]
        public string ConfirmPassword { get; set; }
        public required int UserType { get; set; }
        public int IsActive { get; set; }
    }
}
