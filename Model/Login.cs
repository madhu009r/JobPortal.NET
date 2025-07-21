using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace JobPortal.Model
{
    public class Login
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public string Gender { get; set; } = string.Empty;
        public DateOnly userDate { get; set; } 

        public string PhoneNumber { get; set; } = string.Empty;
        public string Role { get; set; } = "User"; // Default role can be set to "User"
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        // Additional properties can be added as needed

        public DateTime Lastlogin { get; set; } = DateTime.UtcNow;


        public Login()
        {
            // Default constructor
        }

        public Login(int id, string name, string email, string password, String gender, DateOnly dob ,string ph,
            string role,DateTime creatat, DateTime Updated, DateTime lt )
        {
            Id=id;
            Name=name;
            Email=email;
            Password=password;
            Gender=gender;
            userDate = dob;
            PhoneNumber = ph;
            Role=role;
            CreatedAt=creatat;
            UpdatedAt=Updated;
            Lastlogin=lt;
        }

    }
}
