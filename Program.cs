using System;

namespace SortingAlgoPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstIntArray = {35, 15, 308, 12, -2, 5, 167, 24, 8, 95, 0, -1, -1, 18, 99, 30000, 2, 1, 3, 4};
            BubbleSort.Sort(firstIntArray);
            foreach(int num in firstIntArray){
                System.Console.Write(num + " ");
            }
        }
    }
}
