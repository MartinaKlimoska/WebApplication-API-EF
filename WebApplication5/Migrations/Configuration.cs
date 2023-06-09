namespace WebApplication5.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication5.Models.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebApplication5.Models.MyDbContext";
        }

        protected override void Seed(WebApplication5.Models.MyDbContext context)
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

            context.Movies.AddOrUpdate(
                new Models.Movie
                {
                    Id = 0, Title = "Avatar", Rating = (float)7.8
                },
                new Models.Movie
                {
                    Id = 1,
                    Title = "Host",
                    Rating = (float)6.5
                },
                new Models.Movie
                {
                    Id = 2,
                    Title = "The Godfather",
                    Rating = (float)8
                }
                ); ;
        }
    }
}
