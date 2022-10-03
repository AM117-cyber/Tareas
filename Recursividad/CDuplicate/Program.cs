
int[] nums = { 1, 2, 5, 0, 11, -2, 262, -13, 78, -67, -100, 90, 987698698, 434789, 134, 907087, 576456, 2543, 8609870, 67316, 09789, 9, -578, 08, -50 };

bool containsDuplicate = ContainsDuplicate(nums);
static bool ContainsDuplicate(int[] nums)
{
    return CheckD(nums, 0, 1);
}

static bool CheckD(int[] nums, int i, int j)
{
    if (i == nums.Length - 2)
    {
        return nums[i] == nums[i + 1];
    }

    if (nums[i] == nums[j])
    {
        return true;
    }
    if (j == nums.Length - 1)
    {
        return CheckD(nums, i + 1, i + 2);
    }
    return CheckD(nums, i, j + 1);
}

string s = "ddshmygardenisfullofblueliliesandnotoadsaretobeseenasfarasmeetstheeyehaad";
string t = "mygardenisfullofblueliliesandsdhdnotoadsaretobeseenasfarasmeetstheeyeahad";


bool isAnagram = IsAnagram(s,t);
static bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
    {
        return false;
    }
    return A(s, t);
}

static bool A(string s, string t)
{


    t = t.Replace(s[0], ' ').Trim();

    s = s.Replace(s[0], ' ').Trim();

    if (s == string.Empty)
    {
        return s == t;
    }

    return A(s, t);
}


static int[] TwoSum(int[] nums, int target)
{
    return GetSum(nums, target, 0, 1);
}

static int[] GetSum(int[] nums, int target, int i, int j)
{
    int[] answer = new int[2];
    if (i == nums.Length - 1)
    {
        answer[0] = answer[1] = -1;
        return answer;
    }
    int sum = nums[i] + nums[j];
    if (sum == target)
    {
        answer[0] = i;
        answer[1] = j;
        return answer;
    }
    if (j == nums.Length - 1)
    {
        return GetSum(nums, target, i + 1, i + 2);
    }
    return GetSum(nums, target, i, j + 1);
}
System.Console.WriteLine($"{TwoSum(nums, -10)[0]}, {TwoSum(nums, -10)[1]}");