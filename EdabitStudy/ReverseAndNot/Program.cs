namespace Program
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //два способа решения?
            //Первый спобособ
            int i = 123;
            string iStr = i.ToString();
            string result = iStr;

            for (int j = iStr.Length-1; j >= 0; j--) 
            {
                result += iStr[j];
            }
            result += iStr;

            Console.WriteLine(result);
        }
    }
}
