namespace DropkicKExample.migrations
{
    using System.Data.Entity.Migrations;
    using infrastructure.app.persistence;

    /// <summary>
    /// This is the database configuration for migrations
    /// </summary>
    public sealed class DbConfiguration : DbMigrationsConfiguration<DatabaseContext>
    {
        public DbConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DatabaseContext context)
        {
            SeedDatabase(context);
        }

        public static void SeedDatabase(DatabaseContext context) {}
    }
}