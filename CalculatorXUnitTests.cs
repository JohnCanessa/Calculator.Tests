//using Xunit;

using Moq;

namespace Calculator.Tests
{
    public class CalculatorXUnitTests
    {

        /// <summary>
        /// Add two positive values.
        /// </summary>
        [Fact]
        public void AddPositiveValues()
        {

            // **** create a mock argument validator ****
            Mock<IValidateArguments> mockValidator = new Mock<IValidateArguments>();

            // **** set calculator application ****
            var application = new CalculatorApplication
            {
                firstOp = 2,
                secondOp = 3,
                op = "+"
            };

            // **** ****
            mockValidator.Setup(x => x.IsValid(application)).Returns(true);

            // **** sut == system under test (need to use the mock object) ****
            //var sut = new CalculatorEvaluator(new ValidateArguments());
            //var sut = new CalculatorEvaluator(null);
            var sut = new CalculatorEvaluator(mockValidator.Object);

            // **** result of operation "2 + 3 = 5" ****
            var result = sut.Evaluate(application);

            // **** check result ****
            Assert.Equal(5, result);
        }


        /// <summary>
        /// Add two negative values.
        /// </summary>
        [Fact]
        public void AddNegativeValues()
        {

            // **** create a mock argument validator ****
            var mockValidator = new Mock<IValidateArguments>();

            // **** set calculator application ****
            var application = new CalculatorApplication
            {
                firstOp = -2,
                secondOp = -3,
                op = "+"
            };

            // **** ****
            mockValidator.Setup(x => x.IsValid(application)).Returns(true);

            // **** sut == system under test (need to use the mock object) ****
            var sut = new CalculatorEvaluator(mockValidator.Object);

            // **** result of operation "-2 + -3 = -5" ****
            var result = sut.Evaluate(application);

            // **** check result ****
            Assert.Equal(-5, result);
        }


        /// <summary>
        /// Add a positive and a negative value.
        /// </summary>
        [Fact]
        public void AddPositiveAndNegativeValues()
        {

            // **** create a mock argument validator ****
            var mockValidator = new Mock<IValidateArguments>();

            // **** set calculator application ****
            var application = new CalculatorApplication
            {
                firstOp = 5,
                secondOp = -3,
                op = "+"
            };

            // **** ****
            mockValidator.Setup(x => x.IsValid(application)).Returns(true);

            // **** sut == system under test (need to use the mock object) ****
            var sut = new CalculatorEvaluator(mockValidator.Object);

            // **** result of operation "5 + -3 = 2" ****
            var result = sut.Evaluate(application);

            // **** check result ****
            Assert.Equal(2, result);
        }


        /// <summary>
        /// Add a negative and a positive value.
        /// </summary>
        [Fact]
        public void AddNegativeAndPositiveValues()
        {

            // **** create a mock argument validator ****
            var mockValidator = new Mock<IValidateArguments>();

            // **** set calculator application ****
            var application = new CalculatorApplication
            {
                firstOp = -5,
                secondOp = 3,
                op = "+"
            };

            // **** ****
            mockValidator.Setup(x => x.IsValid(application)).Returns(true);

            // **** sut == system under test (need to use the mock object) ****
            var sut = new CalculatorEvaluator(mockValidator.Object);

            // **** result of operation "-5 + 3 = -2" ****
            var result = sut.Evaluate(application);

            // **** check result ****
            Assert.Equal(-2, result);
        }


        /// <summary>
        /// Subtract positive values.
        /// </summary>
        [Fact]
        public void SubtractPositiveValues()
        {

            // **** create a mock argument validator ****
            var mockValidator = new Mock<IValidateArguments>();

            // **** set calculator application ****
            var application = new CalculatorApplication
            {
                firstOp = 5,
                secondOp = 3,
                op = "-"
            };

            // **** ****
            mockValidator.Setup(x => x.IsValid(application)).Returns(true);

            // **** sut == system under test (need to use the mock object) ****
            var sut = new CalculatorEvaluator(mockValidator.Object);

            // **** result of operation "5 - 3 = 2" ****
            var result = sut.Evaluate(application);

            // **** check result ****
            Assert.Equal(2, result);
        }


        /// <summary>
        /// Subtract positive and negative values.
        /// </summary>
        [Fact]
        public void SubtractPositiveAndNegativeValues()
        {

            // **** create a mock argument validator ****
            var mockValidator = new Mock<IValidateArguments>();

            // **** set calculator application ****
            var application = new CalculatorApplication
            {
                firstOp = 5,
                secondOp = -3,
                op = "-"
            };

            // **** ****
            mockValidator.Setup(x => x.IsValid(application)).Returns(true);

            // **** sut == system under test (need to use the mock object) ****
            var sut = new CalculatorEvaluator(mockValidator.Object);

            // **** result of operation "5 - 3 = 2" ****
            var result = sut.Evaluate(application);

            // **** check result ****
            Assert.Equal(8, result);
        }


        /// <summary>
        /// Subtract negative and positive values.
        /// </summary>
        [Fact]
        public void SubtractNegativeAndPositiveValues()
        {

            // **** create a mock argument validator ****
            var mockValidator = new Mock<IValidateArguments>();

            // **** set calculator application ****
            var application = new CalculatorApplication
            {
                firstOp = -5,
                secondOp = 3,
                op = "-"
            };

            // **** ****
            mockValidator.Setup(x => x.IsValid(application)).Returns(true);

            // **** sut == system under test (need to use the mock object) ****
            var sut = new CalculatorEvaluator(mockValidator.Object);

            // **** result of operation "-5 - 3 = -8" ****
            var result = sut.Evaluate(application);

            // **** check result ****
            Assert.Equal(-8, result);
        }


        /// <summary>
        /// Subtract negative values.
        /// </summary>
        [Fact]
        public void SubtractNegativeValues()
        {

            // **** create a mock argument validator ****
            var mockValidator = new Mock<IValidateArguments>();

            // **** set calculator application ****
            var application = new CalculatorApplication
            {
                firstOp = -5.0,
                secondOp = -3.0,
                op = "-"
            };

            // **** ****
            mockValidator.Setup(x => x.IsValid(application)).Returns(true);

            // **** sut == system under test (need to use the mock object) ****
            var sut = new CalculatorEvaluator(mockValidator.Object);

            // **** result of operation "5 - 3 = 2" ****
            var result = sut.Evaluate(application);

            // **** check result ****
            Assert.Equal(-2.0, result);
        }


        /// <summary>
        /// Multiply two positive values.
        /// </summary>
        [Fact]
        public void MultiplyPositiveValues()
        {

            // **** create a mock argument validator ****
            Mock<IValidateArguments> mockValidator = new Mock<IValidateArguments>();

            // **** set calculator application ****
            var application = new CalculatorApplication
            {
                firstOp = 2.0,
                secondOp = 3.0,
                op = "*"
            };

            // **** ****
            mockValidator.Setup(x => x.IsValid(application)).Returns(true);

            // **** sut == system under test (need to use the mock object) ****
            var sut = new CalculatorEvaluator(mockValidator.Object);

            // **** result of operation "2 * 3 = 6" ****
            var result = sut.Evaluate(application);

            // **** check result ****
            Assert.Equal((2.0 * 3.0), result);
        }


        /// <summary>
        /// Multiply two negative values.
        /// </summary>
        [Fact]
        public void MultiplyNegativeValues()
        {

            // **** create a mock argument validator ****
            var mockValidator = new Mock<IValidateArguments>();

            // **** set calculator application ****
            var application = new CalculatorApplication
            {
                firstOp = -2,
                secondOp = -3,
                op = "*"
            };

            // **** ****
            mockValidator.Setup(x => x.IsValid(application)).Returns(true);

            // **** sut == system under test (need to use the mock object) ****
            var sut = new CalculatorEvaluator(mockValidator.Object);

            // **** result of operation "-2 + -3 = -5" ****
            var result = sut.Evaluate(application);

            // **** check result ****
            Assert.Equal((-2.0 * -3.0), result);
        }


        /// <summary>
        /// Divide two positive values.
        /// </summary>
        [Fact]
        public void DividePositiveValues()
        {

            // **** create a mock argument validator ****
            Mock<IValidateArguments> mockValidator = new Mock<IValidateArguments>();

            // **** set calculator application ****
            var application = new CalculatorApplication
            {
                firstOp = 7,
                secondOp = 2,
                op = "/"
            };

            // **** ****
            mockValidator.Setup(x => x.IsValid(application)).Returns(true);

            // **** sut == system under test (need to use the mock object) ****
            var sut = new CalculatorEvaluator(mockValidator.Object);

            // **** result of operation "7 / 2 = 3" ****
            var result = sut.Evaluate(application);

            // **** check result ****
            Assert.Equal((7.0 / 2.0), result);
        }


        /// <summary>
        /// Divide two negative values.
        /// </summary>
        [Fact]
        public void DivideNegativeValues()
        {

            // **** create a mock argument validator ****
            var mockValidator = new Mock<IValidateArguments>();

            // **** set calculator application ****
            var application = new CalculatorApplication
            {
                firstOp = -2,
                secondOp = -3,
                op = "/"
            };

            // **** ****
            mockValidator.Setup(x => x.IsValid(application)).Returns(true);

            // **** sut == system under test (need to use the mock object) ****
            var sut = new CalculatorEvaluator(mockValidator.Object);

            // **** result of operation "-2 / -3 = 0" ****
            var result = sut.Evaluate(application);

            // **** check result ****
            Assert.Equal((-2.0 / -3.0), result);
        }


        /// <summary>
        /// Divide two negative values.
        /// </summary>
        [Fact]
        public void DivideByZero()
        {

            // **** create a mock argument validator ****
            var mockValidator = new Mock<IValidateArguments>();

            // **** set calculator application ****
            var application = new CalculatorApplication
            {
                firstOp = 7,
                secondOp = 0,
                op = "/"
            };

            // **** ****
            mockValidator.Setup(x => x.IsValid(application)).Returns(true);

            // **** sut == system under test (need to use the mock object) ****
            var sut = new CalculatorEvaluator(mockValidator.Object);

            // **** result of operation "7 / 0 = infinite" ****
            var result = sut.Evaluate(application);

            // **** check result ****
            Assert.Equal(double.PositiveInfinity, result);
        }
    }
}