using System.Reflection.Metadata;

namespace Assignment2
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine();//creates a blank line
            Console.WriteLine("This is String iteration in C#");//text for the user
            Console.WriteLine();//creates a blank line
            FunFeatures funObj = new FunFeatures();//getting the FunFeatures.cs
            funObj.Start();//created funObj to be able to get Start() from Funfetures.cs

            ContinueToNextPart();//calling the continueToNextPart method after start
            Console.WriteLine();//creates a blank line
            Console.WriteLine("This is Math work in C#");//text for the user
            MathWork mathWork = new MathWork();//getting the MathWork.cs
            mathWork.Start();//created mathWorks to be able to get Start() from MathWork.cs*/
            
            ContinueToNextPart();//calling the continueToNextPart method after start
            Console.WriteLine();//creates blanks space
            TempretureConverter converter = new TempretureConverter();//getting TempretureConverter.cs
            converter.Start();//created coverted to be able to get Start() from TempretureConverter.cs 
            
            WorkingSchedule workingshcedule = new WorkingSchedule();
            workingshcedule.Start();
        }

        /// <summary>
        /// method to tell the user to continue to the next part
        /// </summary>
        private static void ContinueToNextPart()
        {
            Console.WriteLine(" \nPRESS ENTER TO CONTINUE TO THE NEXT PART");// text for the user
            
            Console.ReadLine();//user input for enter
            
            Console.WriteLine();//creates a blank

            Console.Clear();//clears the console
        }
    }
}