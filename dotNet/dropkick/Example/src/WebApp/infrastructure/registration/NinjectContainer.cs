namespace WebApp.infrastructure.registration
{
    using System;
    using DropkicKExample.infrastructure.app.registration;
    using Ninject;

    /// <summary>
    /// The inversion container
    /// </summary>
    public static class NinjectContainer
    {
        /// <summary>
        /// Sets up a standard kernel with the application and client project bindings
        /// </summary>
        private static readonly Lazy<IKernel> kernel = new Lazy<IKernel>(() => new StandardKernel(new ContainerBinding(), new ContainerBindingWeb()));

        /// <summary>
        /// Gets the kernel.
        /// </summary>
        public static IKernel Kernel
        {
            get
            {
                return kernel.Value;
            }
        }
    }
}