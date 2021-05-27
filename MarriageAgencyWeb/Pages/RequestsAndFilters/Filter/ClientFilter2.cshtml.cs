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
    public class ClientFilter2Model : PageModel
    {
        private readonly MarriageAgencyWeb.Data.MarriageAgencyDBContext _context;

        public ClientFilter2Model(MarriageAgencyWeb.Data.MarriageAgencyDBContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get; set; }
        public Relation Relation { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Relation = _context.Relations.First(m => m.RelationId == id);

            if (Relation == null)
            {
                return NotFound();
            }
            Client = await _context.Clients
                .Include(e => e.Relation).Where(m => m.RelationId == Relation.RelationId).ToListAsync();
            return Page();
        }
    }
}