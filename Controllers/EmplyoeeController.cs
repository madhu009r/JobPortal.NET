using JobPortal.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using JobPortal.Model;
using JobPortal.Authentication;





namespace JobPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmplyoeeController : ControllerBase
    {

        private IConfiguration _configuration;
        EmployeeDb _contextE;

        public EmplyoeeController(EmployeeDb contextE)
        {
            this._contextE = contextE;
        }



        [HttpGet]
        public IActionResult GetEmployees()
        {
            if(this._contextE.Employees != null)
            {
                return Ok(this._contextE.Employees);
            }

            return BadRequest("[]");
            

         }

        [HttpPut("{id}") ]

        public IActionResult UpdateEmployee(int id, string CompanyName,string JobDetails,
            string needed_Qualification, string Experience)
        {
            var user = _contextE.Employees.Find(id);
            if (user != null && AuthStore.LoggedInUsers.ContainsKey(id))
            {
                var emp = _contextE.Employees.Find(id);
                if (emp != null)
                {
                    emp.CompanyName = CompanyName;
                    emp.JobDetails = JobDetails;
                    emp.needed_Qualification = needed_Qualification;
                    emp.Experience = Experience;

                    _contextE.Employees.Update(emp);
                    _contextE.SaveChanges();

                    return Ok(emp);
                }

            }
      
                return BadRequest("no");
        }


        [HttpGet("Validation")]

        public IActionResult ValidateUser(string email, string password)
        {
            var user = _contextE.Employees.FirstOrDefault(u => u.Email == email && u.password == password);
            if (user != null)
            {
                // Update Lastlogin time
                user.LastLogin = DateTime.UtcNow;
                _contextE.SaveChanges();
                AuthStore.LoggedInUsers[user.Id] = (user.Role, DateTime.Now);
                return Ok(new { message = "Login successful"});
            }
            return Unauthorized(new { message = "Invalid email or password" });
        }
    }
}
