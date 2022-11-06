public class Solution
{
    public int Search(int[] nums, int target)
    {
        if (nums.Length == 0) return -1;

        var left = 0;
        var rightPosition = nums.Length - 1;

        while (left < rightPosition)
        {
            var midpoint = left + (rightPosition - left) / 2;

            if (nums[midpoint] > nums[rightPosition])
            {
                left = midpoint + 1;
            }
            else
            {
                rightPosition = midpoint;
            }
        }

        var start = left;
        left = 0;
        var right = nums.Length - 1;

        if (target >= nums[start] && target <= nums[right])
        {
            left = start;
        }
        else
        {
            right = start;
        }

        while (left <= right)
        {
            var midpoint = left + (right - left) / 2;

            if (nums[midpoint] == target)
            {
                return midpoint;
            }
            else if (nums[midpoint] < target)
            {
                left = midpoint + 1;
            }
            else
            {
                right = midpoint - 1;
            }
        }
        
        return -1;
    }
}