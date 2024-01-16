namespace  TestSolution
{
    public class Program 
    {
        static void Main()
        {
            foreach (int item in Validate(new int[]{1,2},2))
            {
                System.Console.WriteLine($"{item}, ");
            }
        }

        static int[] Validate(int[] nums, int k)
        {
        int[] arr = new int[k];
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                dict[nums[i]]++;
            }
            else
            {
                dict.Add(nums[i], 1);    
            }
        }
        
        var pq = new PriorityQueue<int, int>();
        foreach (var key in dict.Keys)
        {
            pq.Enqueue(key, dict[key]);
            if (pq.Count > k) pq.Dequeue();
        }
        while (pq.Count > 0) {
            arr[--k] = pq.Dequeue();
        }
        return arr;
        }
    }
}