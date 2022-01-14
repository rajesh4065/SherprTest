namespace App.UnitTests
{
    using App.Services.Interfaces;
    using System.Collections;
    using System.Collections.Generic;
    using Xunit;

    /// <summary>The CalculatorTests class.</summary>
    public class CalculatorTests
    {
        /// <summary>The IExtendedCalculator.</summary>
        private readonly IExtendedCalculator _extendedCalculator;

        /// <summary>Initialises a new instance of the <see cref="CalculatorTests"/> class.</summary>
        /// <param name="extendedCalculator">logger.</param>
        public CalculatorTests(IExtendedCalculator extendedCalculator)
        {
            _extendedCalculator = extendedCalculator;
        }

        /// <summary>
        /// ShouldAddMethod_ReturnValidResults.
        /// </summary>
        /// <param name="firstNumber">firstNumber.</param>
        /// <param name="secondNumber">secondNumber.</param>
        /// <param name="expectedOutput">expectedOutput.</param>
        [Theory]
        [ClassData(typeof(CalculatorTestDataForAdd))]
        public void ShouldAddMethod_ReturnValidResults(int firstNumber, int secondNumber, int expectedOutput)
        {

            // act
            int actualOutput = _extendedCalculator.Add(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }


        /// <summary>
        /// Should_SubtractMethod_ReturnValidResults.
        /// </summary>
        /// <param name="firstNumber">firstNumber.</param>
        /// <param name="secondNumber">secondNumber.</param>
        /// <param name="expectedOutput">expectedOutput.</param>
        [Theory]
        [ClassData(typeof(CalculatorTestDataForSubtract))]
        public void Should_SubtractMethod_ReturnValidResults(int firstNumber, int secondNumber, int expectedOutput)
        {

            // act
            int actualOutput = _extendedCalculator.Subtract(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        /// <summary>
        /// ShouldMultiplyMethod_ReturnValidResults.
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="expectedOutput"></param>
        [Theory]
        [ClassData(typeof(CalculatorTestDataForMultiply))]
        public void ShouldMultiplyMethod_ReturnValidResults(int firstNumber, int secondNumber, int expectedOutput)
        {

            // act
            int actualOutput = _extendedCalculator.Multiply(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
    }

    /// <summary>The CalculatorTestDataForAdd class.</summary>
    public class CalculatorTestDataForAdd : IEnumerable<object[]>
    {
        /// <summary>The _data.</summary>
        private readonly List<object[]> _data = new List<object[]>
        {
           new object[] { 10, 20,30 }, new object[] { 5,5,10 }, new object[] { 100, 100,200},  new object[] { 500,500,1000 }
        };


        /// <summary>The GetEnumerator.</summary>
        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        /// <summary>
        /// GetEnumerator.
        /// </summary>
        /// <returns>IEnumerator.</returns>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>The CalculatorTestDataForSubtract class.</summary>
    public class CalculatorTestDataForSubtract : IEnumerable<object[]>
    {
        /// <summary>The _data.</summary>
        private readonly List<object[]> _data = new List<object[]>
        {
           new object[] { 30, 20,10 }, new object[] { 10,5,5 }, new object[] { 100, 100,0},  new object[] { 2000,500,1500 }
        };

        /// <summary>The GetEnumerator.</summary>
        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        /// <summary>
        /// GetEnumerator.
        /// </summary>
        /// <returns>IEnumerator.</returns>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>The CalculatorTestDataForMultiply class.</summary>
    public class CalculatorTestDataForMultiply : IEnumerable<object[]>
    {
        /// <summary>The _data.</summary>
        private readonly List<object[]> _data = new List<object[]>
        {
           new object[] { 30, 20,600 }, new object[] { 10,5,50 }, new object[] { 100, 100,10000},  new object[] { 2000,1000,2000000 }
        };

        /// <summary>The GetEnumerator.</summary>
        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        /// <summary>
        /// GetEnumerator.
        /// </summary>
        /// <returns>IEnumerator.</returns>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
