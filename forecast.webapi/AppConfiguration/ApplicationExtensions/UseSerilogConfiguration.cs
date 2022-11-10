using Serilog;

namespace forecast.webapi.AppConfiguration.ServicesExtensions{
    public static partial class AppExtensions
    {
        /// <summary>
        /// Use serilog configuration
        /// </summary>
        /// <param name="app"></param>
        public static void UseSerilogConfiguration(this IApplicationBuilder app)
        {
            app.UseSerilogRequestLogging();
        }
    }
}