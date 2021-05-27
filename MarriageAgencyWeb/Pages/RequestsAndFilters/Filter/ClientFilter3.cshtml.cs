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
    public class ClientFilter3Model : PageModel
    {
        private readonly MarriageAgencyWeb.Data.MarriageAgencyDBContext _context;

        public ClientFilter3Model(MarriageAgencyWeb.Data.MarriageAgencyDBContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get; set; }
        public Nationality Nationality { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Nationality = _context.Nationalities.First(m => m.NationalityId == id);

            if (Nationality == null)
            {
                return NotFound();
            }
            Client = await _context.Clients
                .Include(e => e.Nationality).Where(m => m.NationalityId == Nationality.NationalityId).ToListAsync();
            return Page();
        }
    }
}