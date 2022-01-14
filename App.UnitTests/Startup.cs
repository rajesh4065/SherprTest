namespace App.UnitTests
{
    using App.Services.Implementation;
    using App.Services.Interfaces;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>The Startup class.</summary>
    public class Startup
    {
        /// <summary>
        /// ConfigureServices.
        /// </summary>
        /// <param name="services">services.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IExtendedCalculator, Calculator>();
        }
    }
}
