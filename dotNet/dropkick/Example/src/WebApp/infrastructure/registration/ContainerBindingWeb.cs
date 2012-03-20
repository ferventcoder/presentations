namespace WebApp.infrastructure.registration
{
    using Models;
    using Ninject.Modules;

    /// <summary>
    /// The inversion container binding for the application. 
    /// This is client project specific - contains items that are only available in the client project.
    /// Look for the broader application container in the core project.
    /// </summary>
    public class ContainerBindingWeb : NinjectModule
    {
        /// <summary>
        /// Loads the module into the kernel.
        /// </summary>
        public override void Load()
        {
            Bind<IFormsAuthenticationService>().To<FormsAuthenticationService>().InRequestScope();
        }
    }
}