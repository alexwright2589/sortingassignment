using System;

namespace SortingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Road1 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_1_256.txt"), int.Parse);
            int[] Road2 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_2_256.txt"), int.Parse);
            int[] Road3 = Array.ConvertAll(System.IO.File.ReadAllLines("Road_3_256.txt"), int.Parse);

            Quicksort quickSort = new Quicksort();
            int[] SortedRoad1 = quickSort.QuickSort(Road1);
            int[] SortedRoad2 = quickSort.QuickSort(Road2);
            int[] SortedRoad3 = quickSort.QuickSort(Road3);
            GetEveryNthValue(Road1);
        }

        private static void GetEveryNthValue(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i]);
            }
        }
        
    }
}