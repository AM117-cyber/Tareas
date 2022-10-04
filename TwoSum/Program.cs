int[] arr = {1, 54, 2 , 12, -2, 0};
static int[] TwoSum(int[] nums, int target)
{
    int[] answer = {-1,-1};
    for (int i = 0; i < nums.Length-1; i++)
    {
        for (int j = i+1; j < nums.Length; j++)
        {
            if ((nums[i] + nums[j]) == target)
            {
                answer[0] = i;
                answer[1] = j;
                return answer;
            }
        }
    }
    return answer;
}
System.Console.WriteLine(TwoSum(arr,0)[0]);
System.Console.WriteLine(TwoSum(arr,0)[1]);