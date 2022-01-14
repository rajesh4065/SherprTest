namespace App.Services.Interfaces
{
    /// <summary>The IExtendedCalculator  interface.</summary>
    public interface IExtendedCalculator : ICalculator
    {
        /// <summary>
        /// Multiply.
        /// </summary>
        /// <param name="number1">number1.</param>
        /// <param name="number2">number2.</param>
        /// <returns>multiplication of two numbers.</returns>
        int Multiply(int number1, int number2);
    }
}
