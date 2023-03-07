public class Solution {

    public int[] TwoSum(int[] nums, int target) {
    int[] test=  new int[2];

        for(var i=0;i<nums.Length;i++)
        {
         for(var j=0;j<nums.Length;j++)
            {
                System.Diagnostics.Debug.WriteLine(nums[i]+nums[j]);
                if((nums[i]+nums[j] == target) && (i!=j))
                {
                test[0]=i;
                test[1]=j;
               return test;
               }

            }
               
        }
           return null;          
    }
}