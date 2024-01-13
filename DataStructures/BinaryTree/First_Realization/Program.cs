namespace  First_Realization;


public class Program 
{
    static void Main()
    {
        Tree tree = new Tree();

        int[] arr = {10,2,22,14,30,34,18,12,13,20,18,18};

        for (int i = 0; i < arr.Length; i++)
        {
            tree.Add(arr[i]);
        }

        tree.Remove(22);
    }
}