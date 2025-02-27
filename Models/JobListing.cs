using System.ComponentModel.DataAnnotations;

namespace MVCAssignment.Models
{
  public enum JobType { Full_time, Part_ime, Remote, Contract };
  public class JobListing
  {
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public string Company { get; set; }
    public string Location { get; set; }
    public JobType Type { get; set; }
    public DateTime PostedDate { get; set; }
  }
}