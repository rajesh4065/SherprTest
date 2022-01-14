namespace App.Services.Implementation
{
    using App.Services.Interfaces;
    using System;

    /// <summary>The Thinker class.</summary>
    public class Thinker : IThinker
    {
        /// <summary>The ILogger.</summary>
        private readonly ILogger _logger;

        /// <summary>The IExtendedCalculator.</summary>
        private readonly IExtendedCalculator _iExtendedCalculator;

        /// <summary>Initialises a new instance of the <see cref="Thinker"/> class.</summary>
        /// <param name="logger">logger.</param>
        /// <param name="iExtendedCalculator">iExtendedCalculator.</param>
        public Thinker(ILogger logger, IExtendedCalculator iExtendedCalculator)
        {
            _logger = logger;
            _iExtendedCalculator = iExtendedCalculator;
        }

        /// <summary>
        /// MagicNumbers.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">b.</param>
        /// <param name="c">c.</param>
        /// <returns>int.</returns>
        public int MagicNumbers(int a, int b, int c)
        {
            var result = 0;
            try
            {
                int c1 = _iExtendedCalculator.Add(_iExtendedCalculator.Add(a, b), c);

                _logger.Info($"c1 :{c1}");

                int c2 = _iExtendedCalculator.Subtract(_iExtendedCalculator.Subtract(b, c), a);

                _logger.Info($"c2 :{c2}");

                int c3 = _iExtendedCalculator.Multiply(_iExtendedCalculator.Multiply(a, b), c);
                _logger.Info($"c3 :{c3}");
                result = c3;
            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message);
            }

            return result;
        }
    }
}
