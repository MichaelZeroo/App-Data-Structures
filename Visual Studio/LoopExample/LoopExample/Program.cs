using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void testForLoop()
        {
            for(int i = 0; i < 50; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i * i);
                if (i == 10)
                    break;
            }

            for (int i = 0; i < 50; i++)
            {
                if (i % 2 != 0)
                    continue;
                Console.WriteLine(i * i);
                if (i == 10)
                    break;
            }
        }
    }
}
