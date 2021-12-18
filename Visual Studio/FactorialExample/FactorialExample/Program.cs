using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialExample
{
    class Program
    {
        static void Main(string[] args)
        {
            factorialExample();
        }

        static void factorialExample()
        {
            int fact = 1;
            
            for (int n = 3; n > 0; n--)
            {
                fact = fact * n;
            }

            Console.WriteLine(fact);
            Console.ReadLine();
        }

    }
}
