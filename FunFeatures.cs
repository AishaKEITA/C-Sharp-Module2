using System;
using System.Globalization;

namespace Assignment2
{
    internal class FunFeatures
    {
        private string? firstName;//variable to get name of the user
        private string? lastName;//variable to get last name of the user
        private string? userEmailAddress;//varibale to get the email address of the user
        private string? userAddStringLength;//variable to count string length
        private bool isRunAgain;//a decision to ask user if they want to run again 
       public void Start()
        {
            ReadFirstName();//gets firstName of the user
            ReadLastName();//gets last name of the user
            ReadUserEmailAdress();//gets email address of the user
            GetUserEmailAdressAndFullName();//gets users full information
            PredictTheDay();//gets the predict day function
            CalculateStringLength();//calculates the string character function
            RunAgain();//runs the application if the user wants
        }

      /// <summary>
      /// method that get the name variable 
      /// </summary>
      private void ReadFirstName()
        {
            Console.WriteLine("My name is: Aisha and I am a student of the C# Programming course for the Autum semester!");//intro of myself

            Console.WriteLine();//creates a blank line

            Console.WriteLine("Let me know about yourself!");//get info about the user

            Console.WriteLine();//creates a blank line

            Console.WriteLine("Your first name please:");//asking the users their first name
                
            firstName = Console.ReadLine();//using the variable firstName to get the users first name

            Console.WriteLine();

        }

        /// <summary>
        /// method that gets the last name of the user
        /// </summary>
        private void ReadLastName()
        {
            Console.WriteLine("Your last name please:");//asking the user for their last name

            lastName = Console.ReadLine();//using the variable lastName to get the user last name

            Console.WriteLine( $"Nice to meet you { firstName }! ");//welcoming the user with insert of first name

            Console.WriteLine();
        }

        /// <summary>
        /// method that get the users email address
        /// </summary>
        private void ReadUserEmailAdress()
        {
            Console.WriteLine("Give me your email address please:");//asking the user for their email address

            userEmailAddress = Console.ReadLine();//using variable userEmailAddress to get the user email address

            Console.WriteLine();
        }
        /// <summary>
        /// method to get user full name and email adress
        /// </summary>
        private void GetUserEmailAdressAndFullName()
        {
            Console.WriteLine("Here is your full name and email address");//text to show the user full name and email address
            /***welcoming back user with first and last name(changed last name in caps)  ***/
            string strLastName = new CultureInfo("en-US").TextInfo.ToTitleCase(lastName!);
            Console.WriteLine(firstName!.ToUpper() + ", " + strLastName + ", " + userEmailAddress); //using firtName, lastName, and UserEmailAddress variable to display full info to the user

            Console.WriteLine();
        }

        /// <summary>
        /// a while loop is been used here
        /// to enhance looping through 8
        /// </summary>
        private void PredictTheDay()

        {
            int day = 1;//controls the number of iterations

            while (day <= 7)
            {

                Console.WriteLine("Select a number between 1 and 7:");//text input for the user know that the number range is between 1 and 7

                string? strDayName = Console.ReadLine();
                day = int.Parse(strDayName!);

                switch (day)
                {
                    case 1:
                        day = 1;
                        Console.WriteLine("Monday: Keep calm my friend! You can fall apart!");//if number is 1 text output for the user should be monday
                        break;

                    case 2:
                            day = 2;
                        Console.WriteLine("Tuesday break your heart!");//if number is 2 text output for the user should be tuesday yay!
                        break;

                    case  3:
                            day = 3;
                        Console.WriteLine("Wednesday break your heart!");//if number is 3 text output for the user is Wednesday is the middle of the week
                        break;
                    case 4:
                        day = 4;
                        Console.WriteLine("Thursday, OMG, still one day to Friday!");//if number is 4 text output for the user is thursday is almost friday
                        break;
                    case 5:
                        day = 5;
                        Console.WriteLine("It's Friday! You are in love!");//if number is 5 output for the user is friday the weekend is her
                        break;
                    case 6:
                        day = 6;
                        Console.WriteLine("Saturday, do nothing and do plenty of it!");//if number is 6 output to the user is saturday relax all you want
                        break;
                    case 7:
                        day = 7;
                        Console.WriteLine("And Sunday always comes too soon!");//if number is 7 output for the user is sunday fun day
                        break;

                    default:
                        Console.WriteLine("Not in a good mode? This is not a valid date!");//if user enters something not within 1 and 7 this text will show
                        break;
                }

                Console.WriteLine();

                return;//terminates the loop process
            }

        }
        /// <summary>
        /// this method will read user input of a string
        /// calulate the number of strings in the input
        /// must use a switch case
        /// then do a call in the start method
        /// </summary>
        private void CalculateStringLength()
        {

            Console.WriteLine("Length of a text: Write a text with any number of character and press Enter" +
                " I will then calculate the number chars included in the text");//input text info for the user

            Console.WriteLine("Give me a text or press Enter to exit!");//input text for the user to add a string

            userAddStringLength = Console.ReadLine()!;//user input text will show

            string str = "one";//this variable is the controling statement which is going to be evaluated once then jump to the code block

            switch (str)
            {

                case "one":
 
                    Console.WriteLine("Number of chars = " + userAddStringLength.Length);//gives the length of the string that the user input
                    break;

                default:

                    break;
            }

        }
        /// <summary>
        /// The method should run again
        /// if y or Yesthe user should to continue
        /// otherwis if n or No the program should exit
        /// </summary>
        private void RunAgain()
        {
            
            Console.WriteLine("Run again? (y/n)?");//text input for the user to choose y/n
            
            string? response = Console.ReadLine()!;//to check if y/n


            if ( (response == "y") || (response == "Y") || (response == "yes") & (isRunAgain == false))//check if the user wants to continue using the string of y, Y or y es

            {

                isRunAgain = true;//means yes the user wants to proceed

                Console.WriteLine($"Welcome back  {firstName}");

                Console.WriteLine();

                CalculateStringLength();//calling CalculateStringLength() to run it again by the wish of the user
            }
            else
            {
                isRunAgain = false;//if no the user does not want to proceed

                /***welcoming back the user with first and last name(changed last name to caps)  ***/
                string strLastName = new CultureInfo("en-US").TextInfo.ToTitleCase(lastName!);
                Console.WriteLine("Welcome back " + firstName!.ToUpper() + " " + strLastName); 
            }
        }
    }
}
