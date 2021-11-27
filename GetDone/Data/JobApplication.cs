using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GetDone.Data
{
    public class JobApplication
    {
        public int Id { get; set; }
        public Guid OwnerId { get; set; }
        public int JobId { get; set; }
        public Job Job { get; set; }
        [ForeignKey(nameof(JobUser))]
        public string JobUserId { get; set; }
        public JobUser JobUser { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public string Comment { get; set; }
    }
}
