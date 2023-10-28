namespace RandomChar 
{
    using System ;
    class Program
    {
        static void Main(string[] args) 
        {
            Random random = new Random();
            char a = Convert.ToChar(random.Next('a','z'+1));            
            char b = (char)random.Next('a','z'+1);
            byte c = (byte)random.Next('a','z'+1);
            char d = (char)c;
            
            Console.WriteLine($"{a}\n{b}\n{c}\n{d}");
        }
    }
}