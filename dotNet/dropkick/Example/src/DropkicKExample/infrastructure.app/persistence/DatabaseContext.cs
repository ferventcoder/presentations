using System.Data.Entity;
using DropkicKExample.domain;
using DropkicKExample.infrastructure.persistence;

namespace DropkicKExample.infrastructure.app.persistence
{
    using logging;

    /// <summary>
    ///   The data context for the application
    /// </summary>
    public class DatabaseContext : DbContext, IDataContext
    {
        /// <summary>
        ///   Initializes a new instance of the <see cref="DatabaseContext" /> class.
        /// </summary>
        public DatabaseContext()
            : base(ApplicationParameters.ConnectionStringName)
        {
            InitializeCustomOptions();
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref="DatabaseContext" /> class.
        /// </summary>
        /// <param name="connectionStringName"> Name of the connection string. </param>
        public DatabaseContext(string connectionStringName)
            : base(connectionStringName)
        {
            InitializeCustomOptions();
        }

        /// <summary>
        /// Initializes the custom options.
        /// </summary>
        private void InitializeCustomOptions()
        {
            // defaults for quick reference
            //Configuration.LazyLoadingEnabled = true;
            //Configuration.ProxyCreationEnabled = true;
            //Configuration.AutoDetectChangesEnabled = true;
            //Configuration.ValidateOnSaveEnabled = true;

            Configuration.LazyLoadingEnabled = true;
            //Configuration.ValidateOnSaveEnabled = false;
        }

        /// <summary>
        ///   This method is called when the model for a derived context has been initialized, but before the model has been locked down and used to initialize the context. The default implementation of this method does nothing, but it can be overridden in a derived class such that the model can be further configured before it is locked down.
        /// </summary>
        /// <param name="modelBuilder"> The builder that defines the model for the context being created. </param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<IncludeMetadataConvention>();

            modelBuilder.Entity<SampleUser>()
                .HasKey(e => e.Id)
                .ToTable("Users", "dk")
                ;

            modelBuilder.Entity<SampleParentObject>()
                .HasKey(e => e.Id)
                .ToTable("Parents", "dk")
                ;
                
            modelBuilder.Entity<SampleParentObject>()
                .HasMany<SampleChildObject>(e => e.Children)
                .WithRequired(e => e.ParentObject)
                .HasForeignKey(e => e.ParentObjectId)
                ;

            modelBuilder.Entity<SampleChildObject>()
                .HasKey(e => e.Id)
                .ToTable("Children", "dk")
                ;
        }
    }
}