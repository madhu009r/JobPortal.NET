namespace JobPortal.Model
{
    public class JobSeeker
    {

        public int Id { get; set; }
        public string Name { get; set; } 

        public string Email { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public string Gender { get; set; }

        public DateOnly userDate { get; set; }

        public string Qualification { get; set; } = string.Empty;

        public string Experience { get; set; } = string.Empty;

        public int InProgress { get; set; }
        public Boolean IsActive { get; set; } 

        public Boolean Applied_status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public JobSeeker()
        {
            // Default constructor
        }
    }
}
