using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCTutorial.Models
{
    public class EmployeeContext:DbContext
    {
        public DbSet<Player> Player { get; set; }

        public DbSet<Team> Teams { get; set; }
    }
}