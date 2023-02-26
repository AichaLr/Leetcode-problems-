public class Solution
{
    public int MaxProduct(int[] nums)
    {

        int min = 1;
        int max = 1;
        int res = 0;

        if (nums.Length == 1)
            return nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            var temp = nums[i] * max;
            max = Math.Max(nums[i], Math.Max(nums[i] * min, nums[i] * max));
            min = Math.Min(nums[i], Math.Min(nums[i] * min, temp));
            res = Math.Max(res, max);
        }
        return res;
    }
}