using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class MathWork
    {   
        private bool done = false;//variable to control exit of calculation
        public void Start()
        {
            SumUserNumber();//calling sumNumber function here

        }
 
        /// <summary>
        /// sum number method
        /// checks if startNum is greater than endNum swap it endNum + startNum
        /// </summary>
        public void SumUserNumber()

        {

            do
            {

                Console.WriteLine();//creates a line break

                Console.WriteLine("Sum numbers between any two numbers");//tells the user to add any two numbers

                Console.WriteLine("Give start number:");//tells the user to give a start number
                int startNumber = int.Parse(Console.ReadLine()!);//gets the start number input from the user

                Console.WriteLine("Give end number:");//tells the user to give an end number
                int endNumber = int.Parse(Console.ReadLine()!);//gets the end number input from the user

                if (startNumber > endNumber)
                {
                    int tempSwitchNumber = startNumber;//stores start number temporarily
                    startNumber = endNumber;//start number will store end number
                    endNumber = tempSwitchNumber;//end  number will temp number which store start number
                }

                int totalSum = SumNumbers(startNumber, endNumber);//declared total sum variable and called the SumNumbers() function below to get total sum of number

                /*** 
                 * display input of user start and end number and 
                 * the calculation of the total in totalSum variable 
                ***/

                string text = String.Format("The sum numbers between {0} and {1} is: {2} ", startNumber, endNumber, totalSum);

                Console.WriteLine(text);//outputs text

                Console.WriteLine();

                //displays the result for even numbers between start and end number
                Console.WriteLine("Even numbers between " + startNumber + " and " + endNumber);
                
                PrintEvenNumbers(startNumber, endNumber);//function call for PrintEvenNumbers

                CalculateSquareRoots();//funtion call for calculate square roots

                PrintMultiplicationTable();//function that calls the multiplication table

                done = ExitCalculations();//function call for ExitCalculations

            } while (!done);

        }
        /// <summary>
        /// a for statement looping through start number and end number
        /// </summary>
        /// <param name="startNum"></param>
        /// <param name="endNum"></param>
        /// <returns></returns>
        private int SumNumbers(int startNum, int endNum)

        {   int sum = 0;//declared sum variable to do the calculation of start and end number
            for (int i = startNum; i <= endNum; i++)//for statement for start and end number
            {
                sum = sum + i;
            }
            return sum;
        }

        /// <summary>
        /// method to ask the user to exit calculation
        /// </summary>
        /// <returns></returns>
        private bool ExitCalculations()
        {
            Console.WriteLine();//create a blank line

            Console.WriteLine("Exit calculations? (y/n)");//input for the user to exit or not

            string? response = Console.ReadLine();//gets response of whether to exit or not

            if (((response == "y") || (response == "Y") || (response == "yes") & !done))//checks if response is yes
            {
                done = true;//if yes then done is
            }
            else
            {
                done = false;//otherwise done is false
                SumUserNumber();
            }

            return done;//and it exits the application
        }

        /// <summary>
        /// method to get even numbers between start and end number
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        private void PrintEvenNumbers(int number1, int number2)
        {

            for (int i = number1; i <= number2; i++)//for statement to loop through number1 and number2
            {

                string strValue = "";//variable to store the character format

                if (i % 2 == 0)//finding the remainder of number1 and number2
                {

                    strValue = string.Format("{0, 4:d}", i);//creating a string format to control the display of characters
                    Console.Write(strValue + " ");

                }

                Console.WriteLine();//creates a blank line

            }
            done = ExitCalculations();
        }

        /// <summary>
        /// method for calculating a square root of numbers
        /// based on the users input
        /// </summary>
        public void CalculateSquareRoots()
        {
            int number1 = 0;//variable to get numbe1 
            int number2 = 0;//variable to get number2

            Console.WriteLine("Write first number");//ask users input for the first number
            number1= int.Parse(Console.ReadLine()!);//gets the users input of the first number

            Console.WriteLine("Write second number");//ask users input for the second number
            number2 = int.Parse(Console.ReadLine()!);//gets the users input of the second number

            for (int i = 0; i < number1; i++)//nested loop fot the first number
            {
                for (int j = 0; j < number2; j++)//nested loop for the second number
                {
                    Console.WriteLine(" ");//creates a blank space
                }
                for(int k = 0; k < number2; k++)//nested loop to get the square roots of nunber1 and number2
                {
                    string strValue = Math.Sqrt(k * i).ToString("0.00");//variable to get the square roots
                    Console.Write("{0}\t", strValue);//the \t give a tabs and we are also getting results of square roots
                }

                Console.WriteLine();//creates a blank space
            }
        }

        /// <summary>
        /// method to create a multiplication table that runs from 1-12
        /// make the  table a chart to show the data
        /// more like rows and columns
        /// </summary>
        private void PrintMultiplicationTable()
        {
            Console.WriteLine();
            Console.WriteLine("                             ******** Multiplication Table *******                                    ");

            for (int i = 1; i <= 12; i++)//firt loop to run 12

            {
                for (int j = 1; j <= 12; j++)//second loop to run to 12
                {
                     Console.Write("{0}\t", i * j);//multiply first and second loop to create a multiplication table to run from 1-12 and make a chart
                    //Console.WriteLine(string.Format("{0,4:d} "));//this the explain method by the teacher trying to understand why it is nor working
                }
                Console.WriteLine();//creates a blank space
            }
        }
    }
}
