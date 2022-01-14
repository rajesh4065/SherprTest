namespace App.Services.Implementation
{
    using App.Services.Interfaces;
    using System;

    /// <summary>The Logger class.</summary>
    public class Logger : ILogger
    {
        /// <summary>
        /// Error.
        /// </summary>
        /// <param name="message">message.</param>
        public void Error(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// Info.
        /// </summary>
        /// <param name="message">message.</param>
        public void Info(string message)
        {
            Console.WriteLine(message);
        }
    }
}
