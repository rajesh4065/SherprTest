namespace App.Services.Interfaces
{
    public interface ILogger
    {
        /// <summary>
        /// Info.
        /// </summary>
        /// <param name="message">message.</param>
        void Info(string message);

        /// <summary>
        /// Error.
        /// </summary>
        /// <param name="message">message.</param>
        /// 
        void Error(string message);
    }
}
