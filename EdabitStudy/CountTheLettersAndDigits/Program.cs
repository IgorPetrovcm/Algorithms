namespace Program 
{
    using System;
    using System.Reflection.Metadata.Ecma335;

    class Program 
    {
        static void Main(string[] args) 
        {
            string text = "ee299k5ffc4";
            //var letgit = new { Letters, Digits};
            int digits = 0;
            int letters = 0;
            for (int i = 0; i < text.Length;i++ ) 
            {
                string charTxt = Convert.ToString(text[i]);   
                int digit;             
                if (int.TryParse(charTxt,out digit) == true)
                {
                    digits++;
                    continue;
                }
                if (text[i] == ' ') 
                {
                    continue;
                }
                letters++;
            }
            
            var letgit = new {Letters = letters,Digits = digits};
            System.Console.WriteLine(letgit.Letters + " " + letgit.Digits);
            System.Console.WriteLine(letgit.ToString());
        }
    }
}