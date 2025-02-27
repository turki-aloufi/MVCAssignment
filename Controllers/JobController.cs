using Microsoft.AspNetCore.Mvc;
using MVCAssignment.Models;

namespace MVCAssignment
{
  public class JobController : Controller
  {

    public string Company { get; set; }
    public string Location { get; set; }
    public JobType Type { get; set; }
    public DateTime PostedDate { get; set; }
    private static List<JobListing> jobListing = new List<JobListing>
       {
           new JobListing { Id = 1, Title = "Web Developer", Company="Microsoft", Location= "USA", Type = JobType.Full_time,PostedDate = DateTime.Now},
           new JobListing { Id = 2, Title = "Data Analyst", Company="Apple", Location= "KSA", Type = JobType.Part_ime,PostedDate = DateTime.Now},
           new JobListing { Id = 3, Title = "Mobile Developer", Company="Microsoft", Location= "UAE", Type = JobType.Remote,PostedDate = DateTime.Now},
       };


    public IActionResult Index()
    {
      return View(jobListing);
    }

    public IActionResult Details(int id)
    {
      var job = jobListing.FirstOrDefault(job => job.Id == id);
      if (job == null) return NotFound();
      return View(job);
    }

    public IActionResult Edit(int id)
    {
      var job = jobListing.FirstOrDefault(j => j.Id == id);
      if (job == null)
        return NotFound();

      // Pass JobType enum to the view
      ViewBag.JobTypes = Enum.GetValues(typeof(JobType));
      return View(job);
    }
 // POST: Job/SaveEditing
        [HttpPost]
        public IActionResult SaveEditing(JobListing updatedJob)
        {
            if (ModelState.IsValid)
            {
                // Find the job by Id
                var job = jobListing.FirstOrDefault(j => j.Id == updatedJob.Id);
                if (job != null)
                {
                    // Update job details
                    job.Title = updatedJob.Title;
                    job.Company = updatedJob.Company;
                    job.Location = updatedJob.Location;
                    job.Type = updatedJob.Type;
                    job.PostedDate = updatedJob.PostedDate;

                    return RedirectToAction("Details", new { id = job.Id });
                }
                else
                {
                    return NotFound();
                }
            }

            // If validation fails, return the view with the model
            return View(updatedJob);
        }

  }
}