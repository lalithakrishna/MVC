using Entityframeworkcodefirst.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Entityframeworkcodefirst.Migrations.Identity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Entityframeworkcodefirst.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Identity";
        }

        protected override void Seed(Entityframeworkcodefirst.Models.ApplicationDbContext context)
        {
            var rolemanager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            if (!rolemanager.RoleExists("Admin"))
            {
                rolemanager.Create(new IdentityRole("Admin"));
            }

            if (!rolemanager.RoleExists("Guest"))
            {
                rolemanager.Create(new IdentityRole("Guest"));
            }

            var usermanager=new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            string[] emails = {"a@a.com", "g@g.com"};
            if (usermanager.FindByEmail(emails[0])==null)
            {
                var user = new ApplicationUser { Email = emails[0],UserName = emails[0]};
                var result = usermanager.Create(user, "P@ssw0rd");
                if (result.Succeeded)
                {
                    usermanager.AddToRole(usermanager.FindByEmail(user.Email).Id, "Admin");
                }
            }
            if (usermanager.FindByEmail(emails[1]) == null)
            {
                var user = new ApplicationUser { Email = emails[1], UserName = emails[1] };
                var result = usermanager.Create(user, "P@ssw0rd");
                if (result.Succeeded)
                {
                    usermanager.AddToRole(usermanager.FindByEmail(user.Email).Id, "Guest");
                }
            }
        }
    }
}
