using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment2
{
    internal class WorkingSchedule
    {
        private int year = 52;//variable to get the year

        /// <summary>
        /// start method to be called in the main method
        /// </summary>
        public void Start()
        {
            int choice = -1;//variable to declear choice which check if choice is not  zero to display the below code
            while (choice != 0)
            {
                Console.WriteLine();

                string menuTitle = "Your work schedule";
                Console.WriteLine("\t" + menuTitle.ToUpper());
                
                ShowMenu();
                choice = ReadInput();
            }
            return;
        }

        /// <summary>
        /// displays a menu to the user for selecting weekends or nights and variables
        /// </summary>
        private void ShowMenu()
        {
           

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine($"  {1:##} Show list of the days to work in the weekends");
            Console.WriteLine($"  {2:##} Show list of days to work nights");
            Console.WriteLine($"  {0:##0} Exit the program");


            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
        }
        /// <summary>
        /// Read the input given by the user method
        /// checks if choice is 1, 2, or 0
        /// </summary>
        private int ReadInput()
        {
            bool chosenNumber = false;// variable for chosenNumber
            int choice = 0;//variable for choice set to zero
            do
            {
                Console.WriteLine("Your choice");
                string? input = Console.ReadLine();//gets user input
                chosenNumber = int.TryParse(input, out choice);//assigned chosenNumber variable to be able to convert the input using int.Tryparse

                if(chosenNumber)//checks if chosenNumber
                {
                   if(choice == 1)//checks if chosenNumber is equal to 1
                    {
                        chosenNumber = true;//then set it to true
                        WeekendAndNightShift(2);//calls WeekedAndNightShift method
                    }

                    if (choice == 2)//check if choice is 2
                    {
                        chosenNumber = true;//sets chosen number to true
                        WeekendAndNightShift(3);//calls WeekedAndNightShift method
                    }
                }
            } while (!chosenNumber);//check if other wise

            return choice;//return choice
        }
        /// <summary>
        ///check that the user has to work every second weekend with the start of week 1
        /// check that the the user has to work night shifts every 4th week with the start of week 1
        /// decided to put it in one method because is clearer and readable
        /// since use the same method and pass a parameter to get second and 4th week
        /// </summary>  
        private void WeekendAndNightShift(int weekInterval)
        {
            int col = 0;
            for (int i = 1; i <= year; i += weekInterval)//sets i to 1 when i lest or equal year then interval will added by 1
            {
                Console.Write("Week {0}\t", i);//prints i
                col++;//increment col by 1 everytime till the end of the loop
                if (col >= 4)
                {
                    Console.WriteLine();//if col is greater or equal to 4 create a blank line
                    col = 0;//and set col to 0
                }
            }
            if (col != 0)//otherwise if col is not equal to zero create a blank line
            {
                Console.WriteLine();
            }
        }
    }
}
