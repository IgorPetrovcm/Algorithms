namespace Program
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "Hello World!";
            string txtReverse = null;

            for (int i = 0; i < txt.Length;i++) 
            {
                char a = char.ToLower(txt[i]);
                if (a == txt[i]) {
                    txtReverse += char.ToUpper(a);
                }
                else {
                    txtReverse += a;
                }
            } 

            Console.Write(txtReverse);
        }
    }
}
