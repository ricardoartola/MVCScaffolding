namespace MVCScaffolding.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCScaffolding.Infraestructure.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCScaffolding.Infraestructure.ApplicationDbContext context)
        {
            context.Students.AddOrUpdate(
                new Models.Student() { Name = "John Smith", EnrollmentDate = new DateTime(2020, 9, 1) },
                new Models.Student() { Name = "Albert Nash", EnrollmentDate = new DateTime(2019,1,1) }
            );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
