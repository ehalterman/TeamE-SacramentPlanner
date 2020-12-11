using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TeamE_SacramentPlanner.Models;

namespace TeamE_SacramentPlanner.Data
{
    public class TeamE_SacramentPlannerContext : DbContext
    {
        public TeamE_SacramentPlannerContext (DbContextOptions<TeamE_SacramentPlannerContext> options)
            : base(options)
        {
        }

        public DbSet<TeamE_SacramentPlanner.Models.MeetingProgram> MeetingProgram { get; set; }

        public DbSet<TeamE_SacramentPlanner.Models.Speaker> Speaker { get; set; }
    }
}
