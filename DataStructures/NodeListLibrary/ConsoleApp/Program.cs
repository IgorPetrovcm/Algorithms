namespace ConsoleApp;
using NodeListLib;


class Program 
{
    static void Main()
    {
        Test1();
        Test2();
    }
    private static void Test1()
    {
        NodeList<int> nodes = new NodeList<int>();

        for (int i = 0; i < 10; i++)
        {
            nodes.Add(i);
        }

        System.Console.WriteLine(nodes.Count);

        System.Console.WriteLine(nodes.ToString());

        nodes.Remove(0);
        nodes.Remove(2);
        nodes.Remove(9);

        System.Console.WriteLine(nodes.Count + "\n" + nodes.ToString());
    }
    private static void Test2()
    {
        int[] array = {1,2,3,4,5,6,7};

        List<int> list = new List<int>(){
            1,2,3,4,5,6,7,8
        };

        Stack<int> elements = new Stack<int>();
        for (int i = 0; i < 10; i++) elements.Push(i);

        NodeList<int> nodes = NodeList<int>.UploadUsingEnumerable(elements);
        System.Console.WriteLine(nodes.ToString());

        nodes = NodeList<int>.UploadUsingEnumerable(list);
        System.Console.WriteLine(nodes.ToString());

        nodes = NodeList<int>.UploadUsingEnumerable(array);
        System.Console.WriteLine(nodes.ToString());
    } 
}