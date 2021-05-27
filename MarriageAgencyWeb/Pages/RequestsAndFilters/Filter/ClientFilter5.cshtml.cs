using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MarriageAgencyWeb.Data;
using MarriageAgencyWeb.Models;

namespace MarriageAgencyWeb.Pages.RequestsAndFilters.Filter
{
    public class ClientFilter5Model : PageModel
    {
        private readonly MarriageAgencyWeb.Data.MarriageAgencyDBContext _context;

        public ClientFilter5Model(MarriageAgencyWeb.Data.MarriageAgencyDBContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get; set; }
        public Client Client_ { get; set; }
        public async Task<IActionResult> OnGetAsync(string? FamilyStatus)
        {

            if (FamilyStatus == null)
            {
                return NotFound();
            }

            Client_ = await _context.Clients.FirstOrDefaultAsync(m => m.FamilyStatus == FamilyStatus);

            if (Client_ == null)
            {
                return NotFound();
            }
            Client = await _context.Clients.Where(m => m.FamilyStatus == Client_.FamilyStatus).ToListAsync();
            return Page();
        }
    }
}