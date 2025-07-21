using JobPortal.Data;
using JobPortal.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private IConfiguration _configuration;
        LoginDb _context;
        JobSeekerDb _contextL;
        EmployeeDb _contextE;
        AdminDb _contextA;

        public LoginController(LoginDb context, JobSeekerDb contextL, EmployeeDb contextE, AdminDb contextA)
        {
            _context = context;
            _contextL = contextL;
            _contextE = contextE;
            _contextA = contextA;
        }


        //[HttpGet]
        //public IActionResult Get()
        //{
        //    if (_context.login != null)
        //    {
        //        return Ok(_context.login);
        //    }
        //    return BadRequest("No students found.");
        //}

        [HttpPost("Register")]

        public IActionResult NewRegister(Login login)
        {
          //  _context.login.Add(login);
           
                _context.login.Add(login);
                _context.SaveChanges();
                
            

            if(login.Role == "JobSeeker")
            {
                var jobSeeker = new JobSeeker
                {
                    Id = login.Id,
                    Name = login.Name,
                    Email = login.Email,
                    Password = login.Password,
                    PhoneNumber = login.PhoneNumber,
                    Gender = login.Gender,
                    CreatedAt = login.CreatedAt,
                    UpdatedAt = login.UpdatedAt,

                }; 
                _contextL.JobSeekers.Add(jobSeeker);
                _contextL.SaveChanges();

            }

            else if (login.Role == "Employee")
            {
                var employee = new Employee
                {
                    Id = login.Id,
                    Name = login.Name,
                    Email = login.Email,
                    password = login.Password,
                    Role = login.Role,
                    PhoneNumber = login.PhoneNumber,
                    LastLogin = login.CreatedAt

                };
                _contextE.Employees.Add(employee);
                _contextE.SaveChanges();
            }
            else if (login.Role == "Admin")
            {
                var admin = new Admin
                {
                    Id=login.Id,
                    Name = login.Name,
                    Email = login.Email,
                    Password = login.Password,
                    PhoneNumber = login.PhoneNumber,

                };
                _contextA.Admins.Add(admin);
                _contextA.SaveChanges();
            }

            if(_context.login != null)
            {
                return Ok("Registration successful");
            }
            else
            {
                return BadRequest("Registration failed");
            }
        }

        [HttpGet("Validation")]

        public IActionResult ValidateUser(string email, string password)
        {
            var user = _context.login.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                // Update Lastlogin time
                user.Lastlogin = DateTime.UtcNow;
                _context.SaveChanges();
                return Ok(new { message = "Login successful", user });
            }
            return Unauthorized(new { message = "Invalid email or password" });
        }



    }
}
