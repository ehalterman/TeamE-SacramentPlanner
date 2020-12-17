using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TeamE_SacramentPlanner.Data;
using TeamE_SacramentPlanner.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace TeamE_SacramentPlanner.Pages.Speakers
{
    public class IndexModel : PageModel
    {
        private readonly TeamE_SacramentPlanner.Data.TeamE_SacramentPlannerContext _context;

        public IndexModel(TeamE_SacramentPlanner.Data.TeamE_SacramentPlannerContext context)
        {
            _context = context;
        }

        public IList<Speaker> Speaker { get;set; }
        public IList<MeetingProgram> Meetings { get; set; }

        public string BookSort { get; set; }
        
        public SelectList Notes { get; set; }
        [BindProperty(SupportsGet = true)]
        public string BookSSelect { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }


        public async Task OnGetAsync(string sortOrder)
        {

            BookSort = String.IsNullOrEmpty(sortOrder) ? "book_desc" : "";

            
            IQueryable<string> noteQuery = from m in _context.MeetingProgram
                                           orderby m.MeetingDate
                                           select m.MeetingDate.ToShortDateString();
           
            var books = from m in _context.Speaker select m;

            var meets = from x in _context.MeetingProgram select x;

            if (!string.IsNullOrEmpty(SearchString))
            {
                books = books.Where(s => s.SpeakerName.Contains(SearchString));
            }

             if (!string.IsNullOrEmpty(BookSSelect))
            {
                //////////// Here needs works ////////
                //books = books.Where(x => x.MeetingID == 23);
            }
            // Sort
             switch (sortOrder)
            {
                case "book_desc":
                    books = books.OrderByDescending(s => s.SpeakerName);
                    break;
                default:
                    books = books.OrderBy(s => s.SpeakerName);
                    break;
            }

            Speaker = await books.AsNoTracking().ToListAsync();
            Meetings = await _context.MeetingProgram.ToListAsync();
            Notes = new SelectList(await noteQuery.Distinct().ToListAsync());
        }
    }
}
