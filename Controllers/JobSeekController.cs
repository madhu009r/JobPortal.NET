using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JobPortal.Data;
using JobPortal.Model;
using JobPortal.Authentication;

namespace JobPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobSeekController : ControllerBase
    {
        private IConfiguration _configuration;
        JobSeekerDb _context;
        public JobSeekController(JobSeekerDb _context) { 
            this._context = _context;

        }


        [HttpGet]
        public IActionResult GetAll()
        {
            if(_context.JobSeekers != null)
            {
                return Ok(_context.JobSeekers);
            }

            return BadRequest("No JobSeeker found");
        }

        [HttpPut("{id}")]
        public IActionResult Getby(int id, String Qualification, DateOnly userDate, string Experince) { 

        var jobSeeker = _context.JobSeekers.Find(id);
            if (jobSeeker != null)
            {
                jobSeeker.Qualification =Qualification;
                jobSeeker.userDate = userDate;
                jobSeeker.Experience=Experince;

                _context.JobSeekers.Update(jobSeeker);
                _context.SaveChanges();
                return Ok(jobSeeker);
        }
            return NotFound("JobSeeker not found");
    }

        //  public async Task<IActionResult> UpdateQualification(int id, [FromBody] string Qualification)
        //{
        //    var seeker = await _context.JobSeekers.FindAsync(id);
        //    if (seeker == null)
        //        return NotFound("Job seeker not found.");

        //    seeker.Qualification = Qualification;
        //    await _context.SaveChangesAsync();

        //    return Ok("Phone number updated.");
        //}
    }
}
