using Ninject.Modules;

namespace DropkicKExample.infrastructure.app.registration
{
    using configuration;
    using infrastructure.configuration;
    using infrastructure.persistence;
    using logging;
    using persistence;

    /// <summary>
    /// The main inversion container registration for the application. Look for other container bindings in client projects.
    /// </summary>
    public class ContainerBinding : NinjectModule
    {
        /// <summary>
        /// Loads the module into the kernel.
        /// </summary>
        public override void Load()
        {
            Log.InitializeWith<Log4NetLog>();
            IConfigurationSettings configuration = new ConfigurationSettings();
            Config.InitializeWith(configuration);
            Bind<IConfigurationSettings>().ToMethod(context => configuration);
                        
            Bind<IDataContext>().To<DatabaseContext>().InRequestScope();
            Bind<IRepository>().To<EntityFrameworkRepository>().InRequestScope();
            
        }
    }
}