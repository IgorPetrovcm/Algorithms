namespace Solution1;


public class Program
{
    static void Main()
    {
        foreach (int item in ProductExceptSelf(new int[] {1,2,3,4}))
        {
            System.Console.WriteLine(item);
        }
    }

    static int[] ProductExceptSelf(int[] nums)
    {
        int currentMultiply = 1;

        int[] res = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            res[i] = currentMultiply;
            currentMultiply *= nums[i];
        }

        currentMultiply = 1;

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            res[i] *= currentMultiply;
            currentMultiply *= nums[i];
        }

        return res;
    }
}