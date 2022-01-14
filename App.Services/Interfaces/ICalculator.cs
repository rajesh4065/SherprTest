namespace App.Services.Interfaces
{
    /// <summary>The ICalculator  interface.</summary>
    public interface ICalculator
    {
        /// <summary>
        /// Add.
        /// </summary>
        /// <param name="number1">number1.</param>
        /// <param name="number2">number2.</param>
        /// <returns>sum of two numbers.</returns>
        int Add(int number1, int number2);

        /// <summary>
        /// Subtract.
        /// </summary>
        /// <param name="number1">number1.</param>
        /// <param name="number2">number2.</param>
        /// <returns>substraction of two numbers.</returns>
        int Subtract(int number1, int number2);

    }
}
