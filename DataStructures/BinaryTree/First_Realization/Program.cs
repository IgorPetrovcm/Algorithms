namespace  First_Realization;


public class Program 
{
    static void Main()
    {
        Tree tree = new Tree();

        int[] arr = {6,5,9,4,5,1,7};

        for (int i = 0; i < arr.Length; i++)
        {
            tree.Add(arr[i]);
        }
    }
}