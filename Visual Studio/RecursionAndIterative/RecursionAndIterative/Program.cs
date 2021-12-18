using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionAndIterative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial Number " + computeFactorial(5));
            Console.WriteLine("Recursive Factorial Number " + recursiveComputerFactorial(5));

            Console.WriteLine("Fibonacci Numbers" + fibonacchiNumbers(10));
            Console.WriteLine("Recursive Fibonacci Numbers: " + recursiveFibonacciNumbers(10));

            Console.WriteLine("Power " + power(5, 5));
            Console.WriteLine("Recursive Power " + power(5, 5));

            Console.ReadLine();
        }

        static long computeFactorial(int n)
        {
            long fact = 1;
            for (int i = 1; i <= n; i++)
           // for (int i = n; i>0; i--)
            {
                fact = fact * i;
            }
            return fact;
        }

        static long recursiveComputerFactorial(int n)
        {
            if (n == 0)
                return 1;

            return n * recursiveComputerFactorial(n - 1);
        }

        static long fibonacchiNumbers(int n)
        {
            long fibo1 = 0;
            long fibo2 = 1;
            for(int i = 3; 1 <= n; i++)
            {
                long temp = fibo2;
                fibo2 = fibo1 + fibo2;
                fibo1 = temp;
            }
            return fibo2;
        }

        static long recursiveFibonacciNumbers(int n)
        {
            if (n == 1)
                return 0L;
            if(n == 2)
                return 1L;

            return recursiveFibonacciNumbers(n - 1) + recursiveFibonacciNumbers(n - 2);
        }

        static long power(int x, int n)
        {
            long pow = 1;
            for( int i = n; 1 > 0; i--)
            {
                pow = pow * x;
            }
            return pow;
        }

        static long recursivePower(int x, int n)
        {
            if (n == 1)
            return x;

            return x * recursivePower(x, n - 1);
        }
    }
}
