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
            int? ticketsOnSale = 5600;
            // using null coalescing operator >> if value of ticketOnSale is null/zero then assign zero to that variable , otherwise assign the default value to the respective variable i.e "ticketsOnSale" in this example context : 
            int availableTickets = ticketsOnSale ?? 0;

            Console.WriteLine("Available tickets are = {0}", availableTickets);


            // => Different types of explicit typecasting , implicit are done automatically by the compiler :

            // using  cast () operator conversion =>
             float f = 123456.789F;
            int i = (int)f;

            // or use convert class => , this method is preffered as it throw exceptions if there is a problem !
            int ii = Convert.ToInt32(f);


            // => Parse and TryParse methods to convert strings to int types :

            // int.Parse() method to convert a digiti string to a int datatype :

            string strNumber = "500";
            int result = int.Parse(strNumber);
            Console.WriteLine(result);

            // int.TryParse method to return true or false on successfull or failed conversion :

            string strNumber1 = "123";
            int result1 = 0;
            bool isConversionSuccessfull = int.TryParse(strNumber1, out result1);

            if (isConversionSuccessfull)
            {
                Console.WriteLine(result1);
            } else
            {
                Console.WriteLine("Please Enter a Valid Number !");
            }


            // => Working with Arrays :

            // first method ( not preffered )

            int[] marks = new int[3];
            marks[0] = 95;
            marks[1] = 90;
            marks[2] = 85;
            Console.WriteLine(marks[0]);

            // second method ( preffered )

            int[] marks1 = new int[3] { 50, 60, 70 };
            Console.WriteLine(marks1[1]);

            // third method ( mostly preffered )
            int[] marks2 = {40,30,50};
            for (int i = 0; i < marks2.Length; i++)
            {
                Console.WriteLine(marks2[i]);
            }
        }
    }
}
