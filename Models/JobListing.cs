using System.ComponentModel.DataAnnotations;

namespace MVCAssignment.Models
{
    public enum JobType { Full_time, Part_ime, Remote, Contract }

    public class JobListing
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Company is required.")]
        public string Company { get; set; }

        public string Location { get; set; }

        [Required(ErrorMessage = "Job type is required.")]
        public JobType Type { get; set; }

        [Required(ErrorMessage = "Posted date is required.")]
        [DataType(DataType.Date, ErrorMessage = "Please enter a valid date.")]
        public DateTime PostedDate { get; set; }
    }
}
