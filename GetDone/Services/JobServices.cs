using GetDone.Data;
using GetDone.Models.Job;
using GetDone.Services.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetDone.Services
{
    public class JobServices : IJobServices
    {
        private readonly ApplicationDbContext _db;
        private Guid _USerid;
        public JobServices(ApplicationDbContext db, Guid userid)
        {
            _db = db;
            _USerid = userid;
        }
        public bool Create(JobCreate model)
        {
            var job = new Job
            {
                JobName = model.JobName,
                Created = DateTime.Today,
                ExpectedCompletion = model.ExpectedCompletionDate,
                JobDescription = model.JobDescription,
                ShortDescription = model.ShortDescription,
                Location = model.Location,
                OwnerId = _USerid,
                Status=model.Status

            };
            _db.Jobs.Add(job);
            return _db.SaveChanges() == 1;
        }

        public bool Delete(int id)
        {
            var job = _db.Jobs.FirstOrDefault(u => u.Id == id);
            if (job is null) return false;
            _db.Jobs.Remove(job);
            return _db.SaveChanges() == 1;
        }

        

        public bool Edit(JobEdit model, int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<JobListItem> GetAllJob()
        {
            throw new NotImplementedException();
        }

        public JobDetail GetJob(int id)
        {
            throw new NotImplementedException();
        }

       
    }
}
