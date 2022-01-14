namespace App.DI
{
    using App.Services.Implementation;
    using App.Services.Interfaces;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>The ServiceCollectionExtension class.</summary>
    public static class ServiceCollectionExtension
    {
        /// <summary>
        /// AddLoggerService.
        /// </summary>
        /// <param name="services">services.</param>
        /// <returns>IServiceCollection.</returns>
        public static IServiceCollection AddLoggerService(this IServiceCollection services)
        {
            services.AddScoped<ILogger, Logger>();
            return services;
        }

        /// <summary>
        /// AddServices.
        /// </summary>
        /// <param name="services">services.</param>
        /// <returns>IServiceCollection.</returns>
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IExtendedCalculator, Calculator>();
            services.AddScoped<IThinker, Thinker>();
            return services;
        }
    }
}
