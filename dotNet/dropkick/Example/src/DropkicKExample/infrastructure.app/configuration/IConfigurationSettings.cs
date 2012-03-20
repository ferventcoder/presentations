namespace DropkicKExample.infrastructure.app.configuration
{
    /// <summary>
    /// Configuration settings for the application
    /// </summary>
    public interface IConfigurationSettings
    {
       
        /// <summary>
        /// Gets the system email address.
        /// </summary>
        string SystemEmailAddress { get; }

        /// <summary>
        /// Gets the site URL.
        /// </summary>
        string SiteUrl { get; }
   
    }
}