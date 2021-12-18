using System;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Binary Search");
			TestBinarySearch();
            Console.ReadKey();
        }

		static void TestBinarySearch()
		{
			int[] arr = {12, 23, 37, 48, 52, 64,
				77, 88, 92, 123, 137, 148 };
			for (int i = 0; i < arr.Length; i++)
				Console.Write("\t{0}", arr[i]);
			Console.WriteLine();
			Console.WriteLine("Search Results of {0} are {1}"
			                  , 92, binarySearch(arr, 92));
			Console.WriteLine("Search Results of {0} are {1}"
                              , 12, binarySearch(arr, 12));

		}

		static int binarySearch(int [] array, int value){
			int lowerIndex = 0;
			int upperIndex = array.Length - 1;
			while(lowerIndex < upperIndex){
				int middle = (int) Math.Ceiling(
					(lowerIndex + upperIndex) / 2.0);
				if (array[middle] > value)
					upperIndex = middle - 1;
				else if (array[middle] < value)
					lowerIndex = middle + 1;
				else
					return middle;
			}
			return -1;
		}
    }
}
