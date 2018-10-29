using Entityframeworkcodefirst.Context;

namespace Entityframeworkcodefirst.Migrations.Game
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Entityframeworkcodefirst.Context.GameContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Game";
        }

        protected override void Seed(Entityframeworkcodefirst.Context.GameContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Teams.AddOrUpdate(
                t => t.TeamName,SeededData.getTeams().ToArray());
            context.SaveChanges();

            context.Players.AddOrUpdate(
                p => new {p.FirstName, p.LastName},SeededData.getPlayers(context).ToArray());
        }
    }
}
