namespace BinarySearch 
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    class Program 
    {
        struct DataForSearch 
        {
            public byte Low {get;set;}
            public byte Hight {get;set;}
            public byte Index {get;set;}
            public byte Val {get;set;}
            public DataForSearch(Users[] users) 
            {
                Low = 0;
                Hight = (byte)users.Length;                
            }
        }

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

            byte numberIteration = 0;
            DataForSearch data = new DataForSearch(usersArr);
            while (data.Low <= data.Hight)
            {
                numberIteration++;

                data.Index = (byte)((data.Low + data.Hight) / 2);
                data.Val = usersArr[data.Index].Id;

                if (idInput == data.Val) 
                {
                    Console.WriteLine(usersArr[data.Index].Name);
                    break;
                }
                if (data.Index > idInput-1) 
                {
                    data.Hight = (byte)(data.Index-1);
                }
                else 
                {
                    data.Low = (byte)(data.Index+1);
                }
            }

            Console.WriteLine("Number of iteration: " + numberIteration);
         }
    }

    class Users 
    {
        public string Name {get; set;}
        public byte Id {get; set;}
    }
}