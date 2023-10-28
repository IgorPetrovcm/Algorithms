namespace BynarySearch 
{
    using System;
    class Program 
    {
         static void Main(string[] args) 
         {
            Console.Write("How many users to add: ");
            byte usersQuantity = byte.Parse(Console.ReadLine());

            Users[] usersArr = new Users[usersQuantity];
            
         }
    }

    class Users 
    {
        public string Name {get; set;}
        public byte Id {get; set;}
    }
}