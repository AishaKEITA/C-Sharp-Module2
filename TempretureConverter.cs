
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Assignment2
{
    internal class TempretureConverter
    {
        private double choice;
        public double fahrenhiet;
        public double celsuis;

        /// <summary>
        /// start method to run the application from the start
        /// </summary>
        public void Start()
        {
            ShowMenu();//calls showMenu method  
            do
            {
                CelsiusToFahrenheit();
                FarenheitToCelsuis();
            }
            while(true);
        }

        /// <summary>
        /// should show the user the inputs that they should add
        /// </summary>
        private void ShowMenu()
        {
            while (true)
            {
                 string tempMenu = "Tempreture Converter";//variable for menu

                Console.WriteLine(tempMenu.ToUpper());//change to to upper case
                Console.WriteLine();

                Console.WriteLine("---------------------------------------------");//creates blank space and design
                Console.WriteLine();
                Console.WriteLine("\t"+ "MAIN MENU");//displays main menu to the user
                Console.WriteLine();//create a blank space
                Console.WriteLine("---------------------------------------------");//creates blank space

                Console.WriteLine("\t" + "Celcuis to Fahrenheit  : 1");//text for the user
                Console.WriteLine("\t" + "Fahrenheit Celcuis  : 2");//text for the user
                Console.WriteLine("\t" + "Exit the program  :0");//text for the user
                Console.WriteLine();//blank space
                Console.WriteLine("---------------------------------------------");//blank space with some design
                Console.WriteLine();//creates blank space
                return;
            }
       }
        /// <summary>
        /// conversation method formula for farenheit
        /// </summary>
        /// <param name="celsuis"></param>
        /// <returns></returns>
        private double Farenheit(double celsuis)
        {
            return 9 / 5.0 * celsuis + 32;
        }
        /// <summary>
        /// conversation method formula for celcuis
        /// </summary>
        /// <param name="farenheit"></param>
        /// <returns></returns>
        private double Celsuis(double farenheit)
        {
            return 5 / 9.0 * (farenheit - 32);
        }
        /// <summary>
        /// CelcuisToFarenheit() that converts celsúis to farenheit
        /// should have a constant of: conts int max = 100;
        /// display result such as 1, 4, or 5   
        /// </summary>
        private void CelsiusToFahrenheit()
        {
            const int maxCelNumber = 100;//number for celcuis to be displayed must be 1-100
            Console.WriteLine("Your choice:");//text for the user
            choice = Convert.ToInt32(Console.ReadLine());//getting the user input

            for (int i = 0; i <= maxCelNumber; i++)//for statement to loop through 100
            {

                if (i % 4 == 0)//condition to check and display the remainder of 4 and to get user choice of only 1 in this method
                {
                    fahrenhiet = i;//variable F to loop i
                    Console.WriteLine($"  {i,6:##0.00} Celsuis =  " + $"{Farenheit(fahrenhiet),6:##0.00} Fahrenheit");//creates blank space and string format as well farenheit result
                }
                if (choice == 0)//exit program if choice is 0
                {
                    Environment.Exit(0);
                }
            }

            Console.WriteLine("---------------------------------------------");//creates blank space and design

            Console.WriteLine();
            Console.WriteLine("\t" + "MAIN MENU");//displays main menu to the user
            Console.WriteLine();//create a blank space
            Console.WriteLine("---------------------------------------------");//creates blank space
        }
        /// <summary>
        /// FarenheitToCelcuis()
        /// should have a constant of: conts int max = 212;
        /// display results for every 10th value from F to C
        /// </summary>
        private void FarenheitToCelsuis()
        {
            const int maxFarenNumber = 212;
            Console.WriteLine("Your choice:");//text for the use
            choice = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i <= maxFarenNumber; i++)//for statement to loop max farenheit
            {
                if ((i % 10 == 0))//control flow to get the 10th value
                {
                    celsuis = i;
                    Console.WriteLine($"  {i,6:##0.00} Fahrenheit =  " + $"{Celsuis(celsuis),6:##0.00} Celsuis");//creates blank space and string format as well celsuis result
                }
                if (choice == 0)//exit program if choice is 0
                {
                    Environment.Exit(0);
                }
            }

            Console.WriteLine("---------------------------------------------");//creates blank space and design
            Console.WriteLine();//creates a blank space
            Console.WriteLine("MAIN MENU");//displays main menu to the user
            Console.WriteLine();//create blank space
            Console.WriteLine("---------------------------------------------");//creates blank space
        }
   }
}