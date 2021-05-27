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
    public class ClientFilter4Model : PageModel
    {
        private readonly MarriageAgencyWeb.Data.MarriageAgencyDBContext _context;

        public ClientFilter4Model(MarriageAgencyWeb.Data.MarriageAgencyDBContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get; set; }
        public Client Client_ { get; set; }
        public async Task<IActionResult> OnGetAsync(string? Hobby)
        {

            if (Hobby == null)
            {
                return NotFound();
            }

            Client_ = await _context.Clients.FirstOrDefaultAsync(m => m.Hobbies == Hobby);

            if (Client_ == null)
            {
                return NotFound();
            }
            Client = await _context.Clients.Where(m => m.Hobbies == Client_.Hobbies).ToListAsync();
            return Page();
        }
    }
}