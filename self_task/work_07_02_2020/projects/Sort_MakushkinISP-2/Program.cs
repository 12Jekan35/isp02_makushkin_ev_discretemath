using System;

namespace Sort_MakushkinISP_2
{
    class Program
    {
        static void DisplayArray(int[] array)
        {
            foreach (int item in array)
                Console.Write(item);
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };

            Sort.BubbleSort(array);

            int[] array2 = { 1, 2, 3, 4, 5, 6 };

            Sort.SelectionSort(array2);

            Console.WriteLine("Bubble sort:");
            DisplayArray(array);
            Console.WriteLine();

            Console.WriteLine("Selected sort:");
            DisplayArray(array2);
            Console.WriteLine();

            Console.ReadKey(true);
        }
    }
}
