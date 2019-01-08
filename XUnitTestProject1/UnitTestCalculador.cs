using System;
using Libreria;
using Xunit;

namespace XUnitTestProject1
{
    /* Calculator unit test, what a bad comment!! */
    public class UnitTestCalculadora
    {
        [Fact]
        public void TestCalculatorAdd()
        {
            var Calculadora = new Calculadora();
        }
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(10, 10, 20)]
        [InlineData(-1, -1, -2)]
        //[InlineData(2147483647, 2,2147483647)]
        public void TestCalculadoraAdd(int a, int b, int expected)
        {
            var calculadora = new Calculadora();
            var result = calculadora.Add(a, b);
            Assert.Equal(result, expected);
        }
        [Theory]
        [InlineData(1, 1, 0)]
        //[InlineData(int.MinValue, 1, int.MinValue)]
        //[InlineData(int.MaxValue, -1, int.MaxValue)]
        public void TestCalculadoraSubtract(int a, int b, int expected)
        {
            var calculadora = new Calculadora();
            var result = calculadora.Subtract(a, b);
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(6, 4, 24)]
        //[InlineData(int.MinValue, 2, int.MinValue)]
        //[InlineData(int.MaxValue, -2, int.MaxValue)]
        //[InlineData(int.MaxValue, int.MaxValue, 0)]
        public void TestCalculadoraMultiply(int a, int b,int expected)
        {
            var calculadora = new Calculadora();
            var result = calculadora.multiply(a, b);
            Assert.Equal(result, expected);
        }


        [Theory]
        [InlineData(8, 4, 2)]
        //[InlineData(8,0,0)]
        //[InlineData(Double.MaxValue, 0.5, Double.MaxValue)]
        //[InlineData(Double.MinValue,0.5,Double.MaxValue)]
        public void TestCalculadoraDivide(Double a, double b, double expected)
        {
            var calculadora = new Calculadora();
            var result = calculadora.divide(a, b);
            Assert.Equal(result, expected);
        }
        [Fact]
        public void TestCaculadoraDivideByZero()
        {
            var calculadora = new Calculadora();
            Assert.Throws<DivideByZeroException>(
                  () =>
                  {
                      return calculadora.divide(10, 0);
                  });
        }
        [Fact]
        public void TestCalculadoraAddEdge()
        {
            var calculadora = new Calculadora();
            Assert.Throws<ArgumentOutOfRangeException>(
                () =>
                {
                    return calculadora.Add(int.MinValue, -1);
                });
        }
        [Fact]
        public void TestCalculadoraSubtractEdge()
        {
            var calculadora = new Calculadora();
            Assert.Throws<ArgumentOutOfRangeException>(
                () =>
                {
                    return calculadora.Subtract(int.MaxValue, -1);
                });
        }
        [Fact]
        public void TestCalculadoraMultiplyEdge()
        {
            var calculadora = new Calculadora();
            Assert.Throws<ArgumentOutOfRangeException>(
                () =>
                {
                    return calculadora.multiply(int.MaxValue, 2);
                });
        }
        [Fact]
        public void TestCalculadoraDivideEdge()
        {
            var calculadora = new Calculadora();
            Assert.Throws<ArgumentOutOfRangeException>(
                () =>
                {
                    return calculadora.divide(int.MaxValue, 0.5);
                });
        }


    }
}
