namespace BinarySearch 
{
    using System;
    using System.Runtime.CompilerServices;

    class Program 
    {
        static Users GetUser(byte i) 
        {
            Users user = new Users();
            user.Id = (byte)(i + 1);

            Random rand = new Random();
            for (byte y = 0; y < 3;y++) {
                user.Name += (char)rand.Next('a','z'+1);
            }

            return user;

        }
         static void Main(string[] args) 
         {
            Console.Write("How many users to add: ");
            byte usersQuantity = byte.Parse(Console.ReadLine());

            Users[] usersArr = new Users[usersQuantity];

            for (byte i =0; i < usersArr.Length;i++) {
                Users user = GetUser(i);
                usersArr[i] = user;

                Console.WriteLine(user.Id + ". " + user.Name + "\n");
            }
            
            Console.Write("Output rhe user name under which id: ");
            byte idInput = byte.Parse(Console.ReadLine());

            byte lowIndex = 0;
            byte hightIndex = (byte)usersArr.Length;

            byte indexSearch;
            byte valueUnderIndex;

            while (lowIndex <= hightIndex)
            {
                indexSearch = (byte)((lowIndex + hightIndex) / 2);
                valueUnderIndex = usersArr[indexSearch].Id;

                if (idInput == valueUnderIndex) 
                {
                    Console.WriteLine(usersArr[indexSearch].Name);
                    return;
                }
                if (indexSearch > idInput-1) 
                {
                    hightIndex = (byte)(indexSearch-1);
                }
                else 
                {
                    lowIndex = (byte)(indexSearch+1);
                }
            }

         }
    }

    class Users 
    {
        public string Name {get; set;}
        public byte Id {get; set;}
    }
}