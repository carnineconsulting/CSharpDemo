using System;

namespace VariableDefinition
{
    
    class Program
    {
        static String userName;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter User Name"); 
            
            userName = GetUserName();
            Console.WriteLine(userName);

            userName = SetUserName("Mike");
            Console.WriteLine(userName);

            Console.Read();
        }

        public static String GetUserName()
        {
            userName = Convert.ToString(Console.ReadLine());
            return userName;
        }

        public static String SetUserName(String myName) { 
            return myName;
        }
    }
}
