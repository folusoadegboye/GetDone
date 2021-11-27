using GetDone.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetDone.Models.Job
{
    public class JobCreate
    {
        public string JobName { get; set; }
        
        public string ShortDescription { get; set; }
        
        public string JobDescription { get; set; }
        
        public string Location { get; set; }
        public DateTime ExpectedCompletionDate { get; set; }
        public JobStatus Status { get; set; }
    }
}
