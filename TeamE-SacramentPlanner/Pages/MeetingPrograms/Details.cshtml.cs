using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TeamE_SacramentPlanner.Data;
using TeamE_SacramentPlanner.Models;

namespace TeamE_SacramentPlanner.Pages.MeetingPrograms
{
    public class DetailsModel : PageModel
    {
        private readonly TeamE_SacramentPlanner.Data.TeamE_SacramentPlannerContext _context;

        public DetailsModel(TeamE_SacramentPlanner.Data.TeamE_SacramentPlannerContext context)
        {
            _context = context;
        }

        public MeetingProgram MeetingProgram { get; set; }
        public IList<Speaker> MySpeakers { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MeetingProgram = await _context.MeetingProgram.FirstOrDefaultAsync(m => m.ID == id);
            MySpeakers = await _context.Speaker
                .Where(s => s.MeetingID == id)
                .ToListAsync();

            if (MeetingProgram == null)
            {
                return NotFound();
            }
            return Page();
        }

    }
}
