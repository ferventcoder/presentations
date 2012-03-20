[assembly: WebActivator.PreApplicationStartMethod(typeof(WebApp.App_Start.NinjectMVC3), "Start")]
[assembly: WebActivator.ApplicationShutdownMethodAttribute(typeof(WebApp.App_Start.NinjectMVC3), "Stop")]

namespace WebApp.App_Start
{
    using System.Reflection;
    using DropkicKExample;
    using infrastructure.registration;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Web.Mvc;

    public static class NinjectMVC3 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        ///  Initializes Ninject
        /// </summary>
        public static void Start()
        {
            "NinjectMVC3".Log().Debug("Ninject is starting up");
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestModule));
            DynamicModuleUtility.RegisterModule(typeof(HttpApplicationInitializationModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        ///  Does any shutdown for Ninject
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
            "NinjectMVC3".Log().Debug("Ninject has shut down");
        }

        /// <summary>
        ///   Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            return NinjectContainer.Kernel;
        }  
    }
}
