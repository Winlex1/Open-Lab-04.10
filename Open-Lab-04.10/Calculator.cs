using NUnitLite;
using System;
using System.Linq;

namespace Open_Lab_04._10
{
    public class Calculator
    {
        public float Average(int[] nums)
        {
            float sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                
            }
            float avrg = sum / nums.Length;
            return avrg;
        }
    }
}
