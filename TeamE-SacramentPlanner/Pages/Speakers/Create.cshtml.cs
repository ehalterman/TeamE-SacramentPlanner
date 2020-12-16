using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TeamE_SacramentPlanner.Data;
using TeamE_SacramentPlanner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace TeamE_SacramentPlanner.Pages.Speakers
{
    public class CreateModel : PageModel
    {
        private readonly TeamE_SacramentPlanner.Data.TeamE_SacramentPlannerContext _context;

        public CreateModel(TeamE_SacramentPlanner.Data.TeamE_SacramentPlannerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Speaker Speaker { get; set; }
        public SelectList Meets { get; set; }
        public int Meetid { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Speaker.Add(Speaker);
            await _context.SaveChangesAsync();


            return RedirectToPage("./Index");
        }

        public async Task OnGetAsync()
        {

            // Use LINQ to get list of books.
            var meetQuery = from m in _context.MeetingProgram orderby m.MeetingDate select m.ID;
            Meets = new SelectList(await meetQuery.Distinct().ToListAsync());
        }
    }
}