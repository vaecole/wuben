using algorithm.Solutions;
using System;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new[] { 3 };
            int val = 2;
            var res = new Remove_Element_27().RemoveElement(nums, val);
            Console.WriteLine(res);
        }
    }
}