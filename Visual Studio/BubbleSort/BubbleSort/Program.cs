using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6] { 4, 34, 3, 67, 43, 25};
            bubbleSort(arr);
            Console.ReadKey();
        }

        static void bubbleSort(int[] array)
        {
            
            int temp;
            for(int i = array.Length - 1; i > 0; i--)
            {
                for(int j = 0; j < i; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
                Console.WriteLine("End of Pass {0}", array.Length - i);

                for(int k = 0; k < array.Length; k++)
                    Console.Write("{0}\t", array[k]);
                Console.WriteLine();
            }
        }
    }
}
