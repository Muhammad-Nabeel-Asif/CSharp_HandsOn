using System;

namespace Csharp_ConsoleApp_Basics
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Say Hello to Basics");

            // (1)=> Reading and Write to Console 
            Console.WriteLine("Enter your first name :");
            string FirstName = Console.ReadLine();


            Console.WriteLine("Enter your last name :");
            string LastName = Console.ReadLine();


            // (2)=> Printing Full Name using concatenation method :
            Console.WriteLine("Full Name is = " + FirstName + " " + LastName);


            // (3)=> Printing Full Name using Placeholder method :     ** This method is mostly preffered !
            Console.WriteLine("Complete Name is : {0} - {1}", FirstName, LastName);


            // (4)=> Using verbatim string/literal (@) with "strings":
            string address = @"House # 13 \ Street A \ Housing Colony # 1 \ TTS";
            Console.WriteLine(address);


            // (5)=> nullable data types and use of null coalescing operator : 
            // converting a non-nullable datatype to nullable using symbol "?" on next line :
            int? ticketsOnSale = 5600;
            // using null coalescing operator >> if value of ticketOnSale is null/zero then assign zero to that variable , otherwise assign the default value to the respective variable i.e "ticketsOnSale" in this example context : 
            int availableTickets = ticketsOnSale ?? 0;

            Console.WriteLine("Available tickets are = {0}", availableTickets);


            // (6)=> Different types of explicit typecasting , implicit are done automatically by the compiler :

            // using  cast () operator conversion =>
            float f = 123456.789F;
            int i = (int)f;

            // or use convert class => , this method is preffered as it throw exceptions if there is a problem !
            int ii = Convert.ToInt32(f);


            // (7)=> Parse and TryParse methods to convert strings to int types :

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
            }
            else
            {
                Console.WriteLine("Please Enter a Valid Number !");
            }


            // (8)=> Working with Arrays :

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
            int[] marks2 = { 40, 30, 50 };
            for (int index = 0; index < marks2.Length; index++)
            {
                Console.WriteLine(marks2[index]);
            }


            // (9)=> Working with if_else and switch statements :

            Console.WriteLine("Please Enter a number :");
            int userNumber = int.Parse(Console.ReadLine());

            // if_else statements :

            if (userNumber == 10)
            {
                Console.WriteLine("you entered number :  {0}", userNumber);
            }
            else if (userNumber == 20)
            {
                Console.WriteLine("you entered number :  {0}", userNumber);
            }
            else if (userNumber == 30)
            {
                Console.WriteLine("you entered number :  {0}", userNumber);
            }
            else
            {
                Console.WriteLine("Please Enter a valid number");
            }

            // switch statements :

            switch (userNumber)
            {
                case 10:
                    Console.WriteLine("you entered number :  {0}", userNumber);
                    break;
                case 20:
                    Console.WriteLine("you entered number :  {0}", userNumber);
                    break;
                case 30:
                    Console.WriteLine("you entered number :  {0}", userNumber);
                    break;
                default:
                    Console.WriteLine("Please Enter a valid number");
                    break;
            }


            // Program to prompt user to console and select any coffee size from 1-3 and calculate its price , sum all of them if purchased yet again and show final bill :

            int totalCoffeePrice = 0;

            StartLabel:
            Console.WriteLine("Please Select a Coffee size to buy : 1 - small , 2 - medium , 3 - large ");
            int userChoice = int.Parse(Console.ReadLine());

            switch(userChoice)
            {
                case 1:
                    totalCoffeePrice += 1;
                    break;
                case 2:
                    totalCoffeePrice += 2;                    
                    break;
                case 3:
                    totalCoffeePrice += 3;
                    break;
                default:
                    Console.WriteLine("\n Please Enter a valid choice :~  1 , 2 or 3");
                    goto StartLabel;
            }

            decideLabel:
            Console.WriteLine("\n Do you want to purchase more coffee ? Press 'Y' for yes and 'N' for no");
            string userDecision = Console.ReadLine().ToUpper();

            switch (userDecision)
            {
                case "Y":
                    goto StartLabel;
                case "N":
                    break;
                default:
                    Console.WriteLine("your choice {0} is invalid. Please Try Again ...", userDecision);
                    goto decideLabel;
            }
            Console.WriteLine("Thank You for shopping with us , We hope to see you again :");
            Console.WriteLine("\n Your bill for coffee is : {0}\n", totalCoffeePrice);
        }   
    }
}
