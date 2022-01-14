namespace App.UnitTests
{
    using App.Services.Implementation;
    using App.Services.Interfaces;
    using Moq;
    using System;
    using Xunit;

    /// <summary>The ThinkerTests class.</summary>
    public class ThinkerTests
    {
        /// <summary>
        /// ShouldMagicNumbers_CalculatedAmount_ReturnValid.
        /// </summary>
        [Fact]
        public void ShouldMagicNumbers_CalculatedAmount_ReturnValid()
        {
            // Arrange
            var mockLogger = new Mock<ILogger>();
            mockLogger.Setup(e => e.Info(It.IsAny<string>())).Verifiable();
            var mockExtendedCalculator = new Mock<IExtendedCalculator>();
            mockExtendedCalculator.Setup(x => x.Add(It.IsAny<int>(), It.IsAny<int>())).Returns(50);
            mockExtendedCalculator.Setup(x => x.Subtract(It.IsAny<int>(), It.IsAny<int>())).Returns(10);
            mockExtendedCalculator.Setup(x => x.Multiply(It.IsAny<int>(), It.IsAny<int>())).Returns(3000);

            var mailTransferService = new Thinker(mockLogger.Object, mockExtendedCalculator.Object);

            //Act
            var result = mailTransferService.MagicNumbers(10, 30, 10);

            //Assert
            Assert.Equal(3000, result);
            mockLogger.Verify(e => e.Info(It.IsAny<string>()), Times.Exactly(3));
        }

        /// <summary>
        /// ShouldMagicNumbersMethod_LoggerErrorMethod_Error.
        /// </summary>
        [Fact]
        public void ShouldMagicNumbersMethod_LoggerErrorMethod_Error()
        {
            // Arrange
            var mockLogger = new Mock<ILogger>();
            mockLogger.Setup(e => e.Info(It.IsAny<string>())).Verifiable();
            mockLogger.Setup(e => e.Error(It.IsAny<string>())).Verifiable();
            var mockExtendedCalculator = new Mock<IExtendedCalculator>();
            mockExtendedCalculator.Setup(x => x.Add(It.IsAny<int>(), It.IsAny<int>())).Throws(new Exception());

            var mailTransferService = new Thinker(mockLogger.Object, mockExtendedCalculator.Object);

            //Act
            var result = mailTransferService.MagicNumbers(10, 30, 10);

            //Assert
            mockLogger.Verify(e => e.Error(It.IsAny<string>()), Times.Once);
            mockLogger.Verify(e => e.Info(It.IsAny<string>()), Times.Never);
        }
    }
}
