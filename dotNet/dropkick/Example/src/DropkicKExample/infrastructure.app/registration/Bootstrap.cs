using System;
using DropkicKExample.infrastructure.configuration;
using log4net;
using log4net.Config;

[assembly: XmlConfigurator(Watch = true)]


namespace DropkicKExample.infrastructure.app.registration
{
    using logging;

    /// <summary>
    /// Application bootstrapping - sets up logging and errors for the app domain
    /// </summary>
    public class Bootstrap
    {
        private static readonly log4net.ILog _logger = LogManager.GetLogger(typeof(Bootstrap));

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public static void Initialize()
        {
            //initialization code 
            _logger.Debug("XmlConfiguration is now operational");
        }

        /// <summary>
        /// Startups this instance.
        /// </summary>
        public static void Startup()
        {
            AppDomain.CurrentDomain.UnhandledException += DomainUnhandledException;
            MailSettingsSmtpFolderConverter.ConvertRelativeToAbsolutePickupDirectoryLocation();
            
            _logger.InfoFormat("Performing bootstrapping operations for '{0}'.", ApplicationParameters.Name);

            //todo: perform startup operations here
        }

        /// <summary>
        /// Handles unhandled exception for the application domain.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.UnhandledExceptionEventArgs"/> instance containing the event data.</param>
        private static void DomainUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception;
            var exceptionMessage = string.Empty;
            if (ex != null)
            {
                exceptionMessage = ex.ToString();
            }
            _logger.ErrorFormat("{0} had an error on {1} (with user {2}):{3}{4}",
                                ApplicationParameters.Name,
                                Environment.MachineName,
                                Environment.UserName,
                                Environment.NewLine,
                                exceptionMessage
                );
        }

        /// <summary>
        /// Shutdowns this instance.
        /// </summary>
        public static void Shutdown()
        {
            _logger.InfoFormat("Performing shutdown operations for '{0}'.", ApplicationParameters.Name);
            //todo: perform shutdown operations here
        }
    }
}