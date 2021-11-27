using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GetDone.Data
{

    public enum JobStatus
    {
        Approved=1,
        Declined,
        Open
    }
    public class Job
    {
        public int Id { get; set; }
        [Required]
        public string JobName { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        [Required]
        public string JobDescription { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public DateTime Created { get; set; }
        public DateTime ExpectedCompletion { get; set; }
        public Guid OwnerId { get; set; }
        
        [ForeignKey(nameof(JobUser))]
        public string JobUserId { get; set; }
        public JobUser JobUser { get; set; }
        public DateTime Modified { get; set; }
        public JobStatus Status { get; set; }
        




    }
}
