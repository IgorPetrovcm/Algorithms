namespace Program;
class Program 
{
    static void Main() 
    {
        int[] temperatures = {73, 74,75,71,69,72,76,73};
        int[] output = new int[temperatures.Length];
        for (int i = 0; i < temperatures.Length;i++) 
        {
            for (int j = i+1 ; j < temperatures.Length; j++) 
            {
                if (temperatures[j] > temperatures[i])  
                {
                    output[i] = j - i;
                    break;
                }
            }
        }

        for (int i = 0; i < output.Length;i++) System.Console.WriteLine(output[i]);
    }
}