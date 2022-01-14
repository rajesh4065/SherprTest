namespace App
{
    using App.DI;
    using App.Services.Interfaces;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using System;

    /// <summary>The Startup class.</summary>
    public class Startup
    {
        /// <summary>Gets or sets a serviceCollection.</summary>
        private static IServiceCollection _serviceCollection { get; set; }

        /// <summary>
        /// Startup.
        /// </summary>
        /// <param name="args">args.</param>
        public Startup(string[] args)
        {
            CreateHostBuilder(args).Build();
            var serviceProvider = _serviceCollection.BuildServiceProvider();
            IThinker _calculatorService = serviceProvider.GetService<IThinker>();
            var result = _calculatorService.MagicNumbers(10, 30, 10);
            ILogger loggerService = serviceProvider.GetService<ILogger>();
            loggerService.Info(result.ToString());
            Console.ReadLine();
        }

        /// <summary>
        /// CreateHostBuilder.
        /// </summary>
        /// <param name="args">args.</param>
        /// <returns>IHostBuilder.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                _serviceCollection = services;
                services.AddLoggerService();
                services.AddServices();

            });
    }
}
