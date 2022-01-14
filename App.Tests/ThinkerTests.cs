namespace App.Tests
{
    using App.Services.Implementation;
    using App.Services.Interfaces;
    using Moq;
    using Xunit;

    public class ThinkerTests
    {


        [Fact]
        public void MagicNumbers_Input_ReturnMagicNumber()
        {
            // Arrange
            var mockLoger = new Mock<ILogger>();
            var mockExtendedCalculator = new Mock<IExtendedCalculator>();
            mockExtendedCalculator.Setup(x => x.Add(40, 40)).Returns(80);
            mockExtendedCalculator.Setup(x => x.Subtract(30, 20)).Returns(10);
            mockExtendedCalculator.Setup(x => x.Multiply(300, 10)).Returns(3000);

            var mailTransferService = new Thinker(mockLoger.Object, mockExtendedCalculator.Object);

            //Act

            var result = mailTransferService.MagicNumbers(10, 30, 10);

            //Assert

            Assert.Equal(3000, result);
        }
    }
}
