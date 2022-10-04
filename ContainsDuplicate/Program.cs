int[] nums = {1,9,-3,84,9};
static bool ContainsDuplicate(int[] nums)
{
    for (int i = 0; i < nums.Length-1; i++)
    {
        for (int j = i+1; j < nums.Length; j++)
        {
            if(nums[i] == nums[j])
            {
                return true;
            }
        }
    }
    return false;
}

System.Console.WriteLine(ContainsDuplicate(nums));