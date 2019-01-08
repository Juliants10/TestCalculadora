using System;
namespace Libreria
{
    /* Calculadora de Prueba */
    public class Calculadora
    {
        public long Add(long a, long b)
        {
            long result;
            result = a + b;

            if (result > int.MaxValue)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            else if (result < int.MinValue)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            else
            {
                return (long)result;
            }
        }
            public long Subtract(long a, long b)
        {
            long result;
            result = a - b;
            if (result > int.MaxValue)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            else if (result < int.MinValue)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            else
            {
                return (long)result;
            }
        }
        public long multiply (long a , long b)
        {
            long result;
            result = a * b;
            if (result > int.MaxValue)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            else if (result < int.MinValue)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            else
            {
                return (long)result;
            }
        }
        public double divide(double a, double b)
        {
            double result;
            result = a / b;
            if (b == 0)
            {
                throw new System.DivideByZeroException();
            }
            else if (result > int.MinValue)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            else if (result<int.MinValue)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            {
                return result;
            }
        }
    }
}
