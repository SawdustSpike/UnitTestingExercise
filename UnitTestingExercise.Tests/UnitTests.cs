using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(10, 5, 3, 18)]
        [InlineData(92, 5, 3, 100)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
           var c = new Calculator();


            //Act
            var actual = c.Add(num1, num2, num3);
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,5,5)]
        [InlineData(5, -2, 7)]
        [InlineData(43,11,32)]
        //Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:
            var a = new Calculator();
            //Arrange
            var actual = a.Subtract(minuend, subtrhend);
            //Act
            Assert.Equal(expected, actual);
            //Assert

        }

        [Theory]
        [InlineData(1,1,1)]
        [InlineData(52,0,0)]
        [InlineData(5, -2, -10)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:
            var c = new Calculator();
            var actual = c.Multiply(num1, num2);
            Assert.Equal(expected, actual);
            //Arrange

            //Act

            //Assert

        }

        [Theory]
        [InlineData(45,9,5)]
        [InlineData(100,10,10)]
        [InlineData(50,-5,-10)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var c = new Calculator();
            //Act
            var actual = c.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
