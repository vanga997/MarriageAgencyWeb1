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
    public class ClientFilter1Model : PageModel
    {
        private readonly MarriageAgencyWeb.Data.MarriageAgencyDBContext _context;

        public ClientFilter1Model(MarriageAgencyWeb.Data.MarriageAgencyDBContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get; set; }
        public ZodiacSign ZodiacSign { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ZodiacSign = _context.ZodiacSigns.First(m => m.ZodiacId == id);

            if (ZodiacSign == null)
            {
                return NotFound();
            }
            Client = await _context.Clients
                .Include(e => e.ZodiacSign).Where(m => m.ZodiacId == ZodiacSign.ZodiacId).ToListAsync();
            return Page();
        }
    }
}