using System.Runtime.InteropServices;
using System.Transactions;

namespace Program;
class Program 
{
    static void Main() 
    {
        int[] arr = {73,74,75,71,69,72,76,73};
        int current = 0;
        for (int i = 0; i < arr.Length; ++i) {  
                      
            while (arr[i+current] <= arr[i]) {
                if (i+current == arr.Length-1) {
                    current = 0 ;
                    break;
                }
                current++;                
            }
            
            arr[i] = current;
            current = 0;           
        }
        foreach (int a in arr) 
        {
            System.Console.WriteLine(a);
        }
    }
}