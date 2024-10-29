using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CandidateManagementWebsite.Data;
using Candidate_BuisinessObjects;

namespace CandidateManagementWebsite.Pages.CandidateProfilePage
{
    public class DetailsModel : PageModel
    {
        private readonly CandidateManagementWebsite.Data.CandidateManagementWebsiteContext _context;

        public DetailsModel(CandidateManagementWebsite.Data.CandidateManagementWebsiteContext context)
        {
            _context = context;
        }

        public CandidateProfile CandidateProfile { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidateprofile = await _context.CandidateProfile.FirstOrDefaultAsync(m => m.CandidateId == id);
            if (candidateprofile == null)
            {
                return NotFound();
            }
            else
            {
                CandidateProfile = candidateprofile;
            }
            return Page();
        }
    }
}
