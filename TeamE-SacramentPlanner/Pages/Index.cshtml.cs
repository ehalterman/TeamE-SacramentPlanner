﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TeamE_SacramentPlanner.Data;
using TeamE_SacramentPlanner.Models;

namespace TeamE_SacramentPlanner.Pages
{
    public class IndexModel : PageModel
    {
        private readonly TeamE_SacramentPlanner.Data.TeamE_SacramentPlannerContext _context;

        public IndexModel(TeamE_SacramentPlanner.Data.TeamE_SacramentPlannerContext context)
        {
            _context = context;
        }
        public IList<Speaker> Speaker { get;set; }

        public async Task OnGetAsync()
        {
            Speaker = await _context.Speaker.ToListAsync();
        }

    }
}
