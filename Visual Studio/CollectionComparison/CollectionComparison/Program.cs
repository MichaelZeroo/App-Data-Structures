using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;


namespace CollectionComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //compare addition performance on ArrayList and LinkedList

            List<int> data = new List<int>();

            Stopwatch s = new Stopwatch();

            s.Start();

            for(int i = 0; i< 100000000; i++)
            {
                data.Add(i);
            }
            s.Stop();
            Console.WriteLine("List time for adding data: " + s.Elapsed);



            LinkedList<int> data1 = new LinkedList<int>();

            Stopwatch s1 = new Stopwatch();
            s1.Start();

            for (int i = 0; i < 100000000; i++)
            {
                data1.AddLast(i);
            }
            s1.Stop();
            Console.WriteLine("LinkedList time for adding data: " + s1.Elapsed);
            

            //search data comparison 

            //arraylist
            Stopwatch s2 = new Stopwatch();
            s2.Start();

            data.Contains(9999999);
            s1.Stop();
            Console.WriteLine("List search time taken: " + s2.Elapsed);

            //linkedlist
            Stopwatch s3 = new Stopwatch();
            s3.Start();

            data1.Contains(9999999);
            s1.Stop();
            Console.WriteLine("List search time taken: " + s3.Elapsed);

            Console.ReadKey();

        }
    }
}
