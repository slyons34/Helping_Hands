namespace HelpingHands.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HelpingHands.Models.HelpingHandsEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "HelpingHands.Models.HelpingHandsEntities";
        }

        protected override void Seed(HelpingHands.Models.HelpingHandsEntities context)
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
        }
    }
}
