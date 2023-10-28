namespace NewWay 
{
    using System;
    class Program 
    {
        static void Main(string[] args) 
        {
            Users user = new Users();
            user.Id= 1;
            user.Login = "igor";

            object userN = user;
            Users user2 = (Users)userN;
            
            Console.WriteLine(user2.Login + "\n" + user2.Id);
        }        

    } 

    class Users 
    {
        public byte Id {get;set;}
        public string Login {get;set;}

        public Users() {

        }
    }
}