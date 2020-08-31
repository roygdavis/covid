using Hangfire;
using Hangfire.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace covid.Services
{
    public class JobService
    {
        private readonly ImportWorldDataService _importWorldDataService;
        public JobService(ImportWorldDataService importWorldDataService)
        {
            _importWorldDataService = importWorldDataService;
        }

        public void ConfigureJobs()
        {
            // Gte all hangfire jobs and remove them
            var jobs = JobStorage.Current.GetConnection().GetRecurringJobs();
            foreach (var item in jobs)
            {
                RecurringJob.RemoveIfExists(item.Id);
            }

            RecurringJob.AddOrUpdate("UpdateWorldData", () => _importWorldDataService.ImportWorldData(), Cron.Daily(0, 0));
        }
    }
}
