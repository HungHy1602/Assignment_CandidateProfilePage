using Candidate_BuisinessObjects;
using Candidate_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public class JobPostingRepo : IJobPostingRepo
    {
        public JobPosting GetJobPostingById(string jobId) => JobPostingDAO.Instance.GetJobPostingById(jobId);

        public List<JobPosting> GetJobPostings() => JobPostingDAO.Instance.GetJobPostings();
    }
}
