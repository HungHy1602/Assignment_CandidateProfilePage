using Candidate_BuisinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAO
{
    public class HRAccountDAO
    {
        private CandidateManagementContext dbcontext;

        private static HRAccountDAO instance = null;

        public static HRAccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HRAccountDAO();
                }
                return instance;
            }
        }

        public HRAccountDAO()
        {
            dbcontext = new CandidateManagementContext();
        }

        public Hraccount GetHraccountByEmail(string email)
        {
            return dbcontext.Hraccounts.SingleOrDefault(m => m.Email.Equals(email));
        }

        public List<Hraccount> GetHraccounts()
        {
            return dbcontext.Hraccounts.ToList();
        }

    }
}
