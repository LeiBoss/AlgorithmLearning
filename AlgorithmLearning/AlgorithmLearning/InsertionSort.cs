using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmLearning
{
    /// <summary>
    /// 插入排序
    /// </summary>
    public class InsertionSort
    {
        /// <summary>
        /// 升序
        /// </summary>
        /// <param name="nums"></param>
        public static void AscSort(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                int key = nums[i];
                int j = i - 1;
                while (j >= 0 && nums[j] > key)
                {
                    nums[j + 1] = nums[j];
                    j = j - 1;
                }
                nums[j + 1] = key;
            }
        }
    }
}
