using MathOperations;

namespace SimpleCalculationsUnitTest
{
    public class SimpleCalculationsTests
    {
        [Fact]
        public void NumbersShouldBeAdded()
        {
            SimpleCalculations calculations = new SimpleCalculations();
            double expected = 6+6.5;

            double actual = calculations.Adding(6, 6.5);

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void NumbersShouldSubstract()
        {
            SimpleCalculations calculations = new SimpleCalculations();
            double expected = 12 - 7.5;

            double actual = calculations.Minus(12, 7.5);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HighestNumberShouldBeFirst()
        {
            SimpleCalculations calculations = new SimpleCalculations();
            double expected = 25;

            double actual = calculations.Highest(25, 5);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void HighestNumberShouldBeSecond()
        {
            SimpleCalculations calculations = new SimpleCalculations();
            double expected = 18;

            double actual = calculations.Highest(5,18);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12,5,12)]
        [InlineData(12, 50, 50)]
        public void ShouldReturnHighestNumber(double x, double y, double expected)
        {
            SimpleCalculations calculations = new SimpleCalculations();

            double actual = calculations.Highest(x, y);

            Assert.Equal(expected, actual);
        }
    }
}