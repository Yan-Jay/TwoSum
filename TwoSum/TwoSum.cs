using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class TwoSumClass
    {
        public int[] Convert(int[] nums, int target)
        {
            for(int i=0; i<nums.Length -1; i++)
            {
                for(int j=i+1; j<nums.Length; j++)
                {
                    if (target == nums[i] + nums[j])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { 404 ,404};
        }
    }
}
