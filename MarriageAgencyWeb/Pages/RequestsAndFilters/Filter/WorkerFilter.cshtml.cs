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
    public class WorkerFilterModel : PageModel
    {
        private readonly MarriageAgencyWeb.Data.MarriageAgencyDBContext _context;

        public WorkerFilterModel(MarriageAgencyWeb.Data.MarriageAgencyDBContext context)
        {
            _context = context;
        }

        public IList<Worker> Worker { get; set; }
        public Position Position { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Position = _context.Positions.First(m => m.PositionId == id);

            if (Position == null)
            {
                return NotFound();
            }
            Worker = await _context.Workers
                .Include(e => e.Position).Where(m => m.PositionId == Position.PositionId).ToListAsync();
            return Page();
        }
    }
}