using System;

namespace Csharp_ConsoleApp_Basics
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Say Hello to Basics");

            // Reading and Write to Console 
            Console.WriteLine("Enter your first name :");
            string FirstName = Console.ReadLine();


            Console.WriteLine("Enter your last name :");
            string LastName = Console.ReadLine();
            

            // Printing Full Name using concatenation method :
            Console.WriteLine("Full Name is = " + FirstName + " " + LastName);


            // Printing Full Name using Placeholder method :     ** This method is mostly preffered !
            Console.WriteLine("Complete Name is : {0} - {1}", FirstName, LastName);


            // Using verbatim string/literal (@) with "strings":
            string address = @"House # 13 \ Street A \ Housing Colony # 1 \ TTS";
            Console.WriteLine(address);
        }
    }
}
