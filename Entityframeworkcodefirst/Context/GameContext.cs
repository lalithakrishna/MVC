using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using Entityframeworkcodefirst.Models;

namespace Entityframeworkcodefirst.Context
{
    public class GameContext:DbContext
    {
        public GameContext() : base("DefaultConnection")

        {
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}