public class Solution
{
    public bool IsMonotonic(int[] nums)
    {
        if (nums.Length == 1) return true;

        var result = nums[nums.Length - 1] - nums[0];
        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (result >= 0 && nums[nums.Length - 1] - nums[0] >= 0)
            {
                if (nums[i + 1] >= nums[i]) continue;
                else return false;
            }
            else
            {
                if (nums[i + 1] <= nums[i]) continue;
                else return false;
            }
        }
        return true;
    }
}