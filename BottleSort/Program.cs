using System;
using System.Diagnostics;

namespace BubbleSort
{
    class Program
    {
        static private int[] nums;

        static void Main(string[] args)
        {
            var rnd = new Random();

            nums = new int[10];
            
            for (int i = 0; i < nums.Length; i++)//ввод
            {
                nums[i] = rnd.Next(0, 100);
            }

            for (int t = 0; t < nums.Length; t++)//сортировка
            {
                for (int j = nums.Length - 1; j > t; j--)
                {
                    if (nums[j - 1] > nums[j])
                    {
                        var temp = nums[j - 1];
                        var temp1 = nums[j];

                        nums[j - 1] = temp1;
                        nums[j] = temp;
                    }
                }
            }

            for (int i = 0; i < nums.Length; i++)//вывод
            {
                Console.Write(nums[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
