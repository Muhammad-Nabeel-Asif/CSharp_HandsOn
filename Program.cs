using System;

namespace Csharp_ConsoleApp_Basics
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Say Hello to Basics");

            // => Reading and Write to Console 
            Console.WriteLine("Enter your first name :");
            string FirstName = Console.ReadLine();


            Console.WriteLine("Enter your last name :");
            string LastName = Console.ReadLine();


            // => Printing Full Name using concatenation method :
            Console.WriteLine("Full Name is = " + FirstName + " " + LastName);


            // => Printing Full Name using Placeholder method :     ** This method is mostly preffered !
            Console.WriteLine("Complete Name is : {0} - {1}", FirstName, LastName);


            // => Using verbatim string/literal (@) with "strings":
            string address = @"House # 13 \ Street A \ Housing Colony # 1 \ TTS";
            Console.WriteLine(address);


            // => nullable data types and use of null coalescing operator : 
            // converting a non-nullable datatype to nullable using symbol "?" on next line :
            int? ticketsOnSale = null;
            // using null coalescing operator >> if value of ticketOnSale is null/zero then assign zero to that variable , otherwise assign the default value to the respective variable i.e "ticketsOnSale" in this example context : 
            int availableTickets = ticketsOnSale ?? 0;

            Console.WriteLine("Available tickets are = {0}", availableTickets);

        }
    }
}
