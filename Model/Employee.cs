namespace JobPortal.Model
{
    public class Employee
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string password { get; set; }
        public string Email { get; set; }

        public string Role { get; set; } = string.Empty;// Default role can be set to "Employee"
        public string CompanyName { get; set; } = string.Empty;
        public string JobDetails { get; set; } = string.Empty;

        public string JobTitle { get; set; } = string.Empty;
        public string needed_Qualification { get; set; } = string.Empty;

        public string Experience { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;

        public DateTime job_CreatedAt { get; set; }

        public DateTime job_EndDate { get; set; }

        public DateTime LastLogin { get; set; } 
        public Employee( ) { }
    }
}
