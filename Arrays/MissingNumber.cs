public class Solution
{
    public int MissingNumber(int[] nums)
    {
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i) return i;
            if (i == nums.Length - 1 && nums[nums.Length - 1] != nums.Length) return nums.Length;
        }
        return 0;
    }
}