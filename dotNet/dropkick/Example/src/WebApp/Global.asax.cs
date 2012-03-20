using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApp
{
    using DropkicKExample.infrastructure.app.persistence;
    using DropkicKExample.infrastructure.app.registration;
    using DropkicKExample.infrastructure.logging;
    using DropkicKExample.migrations;
    using log4net;
    using ILog = log4net.ILog;

    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : HttpApplication
    {
        private static ILog _logger;

        private ILog Logger
        {
            get
            {
                if (_logger == null)
                {
                    _logger = LogManager.GetLogger(typeof(MvcApplication));
                }

                return _logger;
            }
        }

        /// <summary>
        /// Registers the global filters.
        /// </summary>
        /// <param name="filters">The filters.</param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        /// <summary>
        /// Registers the routes.
        /// </summary>
        /// <param name="routes">The routes.</param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            _logger.Debug("Registering routes...");
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.IgnoreRoute("{*favicon}", new { favicon = @"(.*/)?favicon.ico(/.*)?" });
            routes.IgnoreRoute("{*imgs}", new { imgs = @"(.*/)?imgs(/.*)?" });

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
                );

        }

        /// <summary>
        /// Global application error event handler
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Application_Error(object sender, EventArgs e)
        {
            // Log unhandled error
            var ex = Server.GetLastError().GetBaseException();
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
        /// Global application start event handler.
        /// </summary>
        protected void Application_Start()
        {

            Bootstrap.Initialize();
            Logger.InfoFormat("Starting '{0}' site.", ApplicationParameters.Name);
            Bootstrap.Startup();

            SeedDatabase();

            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

        }

        /// <summary>
        /// Updates the database.
        /// </summary>
        private static void SeedDatabase()
        {
            //var dbMigrator = new DbMigrator(new DbConfiguration());
            //dbMigrator.Update();
            // The Seed method of DbConfiguration is never called, so 
            //  we call it here as a workaround.

            using (var context = new DatabaseContext())
            {
                DbConfiguration.SeedDatabase(context);
            }
        }

        /// <summary>
        /// Global application end event handler
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Application_End(object sender, EventArgs e)
        {
            Logger.InfoFormat("Shutting down '{0}' site.", ApplicationParameters.Name);
            Bootstrap.Shutdown();
        }
    }
}