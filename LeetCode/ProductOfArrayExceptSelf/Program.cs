using System.Reflection.Metadata;

namespace ProductOfArrayExceptSelf;


public class Program
{
    static void Main()
    {
        foreach (int item in MainFunction(new int[] {-1,1,0,-3,3}))
        {
            System.Console.WriteLine(item);
        }
    }

    static int[] MainFunction(int[] nums)
    {
        int[] resArr = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0) 
            {
                nums[i] = 1;

                resArr[i] = nums.Aggregate((x,y) => x * y);

                nums[i] = 0;

                continue;
            }
            resArr[i] = nums.Aggregate((x,y) => x * y);

            resArr[i] /= nums[i];
        }

        return resArr;
    }
}