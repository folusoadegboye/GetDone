using GetDone.Data;
using GetDone.Models.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetDone.Services.ServiceInterface
{
   public interface IJobServices
    {
        bool Create(JobCreate model);
        bool Edit(JobEdit model, int id);
        bool Delete(int id);
        IEnumerable<JobListItem> GetAllJob();
        JobDetail GetJob(int id);
    }
}
