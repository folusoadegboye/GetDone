using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetDone.Models.Job
{
    public class JobEdit
    {
        public int Id { get; set; }
        public string JobName { get; set; }

        public string ShortDescription { get; set; }

        public string JobDescription { get; set; }

        public string Location { get; set; }
    }
}
