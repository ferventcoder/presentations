namespace DropkicKExample.infrastructure.app.configuration
{
    using System;
    using System.Configuration;
    using System.Net.Configuration;
    using System.Web;

    /// <summary>
    ///   Configuration settings for the application
    /// </summary>
    public class ConfigurationSettings : IConfigurationSettings
    {
        /// <summary>
        ///   Gets the application settings value.
        /// </summary>
        /// <param name = "name">The name.</param>
        /// <returns>A string with the settings value; otherwise an empty string</returns>
        public string GetApplicationSettingsValue(string name)
        {
            return ConfigurationManager.AppSettings.Get(name);
        }

        /// <summary>
        /// Gets the configuration section.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="section">The section.</param>
        /// <returns>The configuration section requested as a strong type; otherwise null</returns>
        public T GetConfigurationSection<T>(string section) where T : ConfigurationSection
        {
            return ConfigurationManager.GetSection(section) as T;
            //var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //return config.GetSectionGroup(section) as T;
        }

        /// <summary>
        /// Gets the SMTP email from mail settings section.
        /// </summary>
        /// <param name="settings">The settings section.</param>
        /// <returns>The From property on <see cref="SmtpSection"/>.</returns>
        public string GetSmtpEmailFromMailSettingsSection(SmtpSection settings)
        {
            if (settings == null) return string.Empty;

            return settings.From;
        }

   

        /// <summary>
        /// Gets the site URL.
        /// </summary>
        public string SiteUrl
        {
            get
            {
                var siteUrl = GetApplicationSettingsValue("Site.Url");
                if (string.IsNullOrWhiteSpace(siteUrl))
                {
                    if (HttpContext.Current != null)
                    {
                        var url = HttpContext.Current.Request.Url;

                        siteUrl = "{0}://{1}:{2}".FormatWith(url.Scheme, url.Host, url.Port);
                    }
                }

                return siteUrl;
            }
        }

      

        /// <summary>
        /// Gets the system email address.
        /// </summary>
        public string SystemEmailAddress
        {
            get { return GetSmtpEmailFromMailSettingsSection(GetConfigurationSection<SmtpSection>("system.net/mailSettings/smtp")); }
        }
    }
}