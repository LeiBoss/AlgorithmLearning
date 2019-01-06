using System;

namespace AlgorithmLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 2, 4, 6, 1, 3 };
            InsertionSort.AscSort(nums);
            Console.WriteLine(string.Join(",",nums));
            Console.ReadKey();
        }
    }
}
