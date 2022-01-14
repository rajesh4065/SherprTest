namespace App.Services.Implementation
{
    /// <summary>The Calculator class.</summary>
    using App.Services.Interfaces;
    public class Calculator : IExtendedCalculator
    {
        /// <summary>
        /// Add.
        /// </summary>
        /// <param name="number1">number1.</param>
        /// <param name="number2">number2.</param>
        /// <returns>sum of two numbers.</returns>
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }


        /// <summary>
        /// Subtract.
        /// </summary>
        /// <param name="number1">number1.</param>
        /// <param name="number2">number2.</param>
        /// <returns>Subtraction of two numbers.</returns>
        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        /// <summary>
        /// Multiply.
        /// </summary>
        /// <param name="number1">number1.</param>
        /// <param name="number2">number2.</param>
        /// <returns>multiplication of two numbers.</returns>
        public int Multiply(int number1, int number2)
        {
            int result = number2;
            while (number1 - 1 != 0)
            {
                result = Add(result, number2);
                number1--;
            }
            return result;
        }
    }
}
