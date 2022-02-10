using System;
//Programmer Name: Meghana Nelluri
//Project: Tech Assignment 3-Using Iterative Statements
//Date: 2/7/22
//This program converts Canadian $ (CAD) to U.S. $ using an iterative statement
namespace Tech_Assignment_3_Using_Iterative_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string tryAgain = "y";
                double cadVal = 0;
                double usdVal;
                const double RATE = 0.792367;

                //Ask user to enter increment values
                int increment;

                Console.WriteLine("Please enter an integer between 0 and 25 to increment CAD shown in each row.");
                increment = int.Parse(Console.ReadLine());

                //Display increment value
                Console.WriteLine("CAD Increment Value = " + increment);

                //Print heading for the table
                Console.WriteLine("CAD            USD");

                //Establish parameters for increment values
                if ((increment > 0) && (increment <= 25))
                    //Establish a loop that allows the user to enter CAD to be converted to U.S.$
                    while (cadVal < 201)
                    {
                        //Calculate USD value using exchange rate
                        usdVal = cadVal * RATE;
                        
                        //Print starting CAD value as a string
                        Console.WriteLine(cadVal.ToString() + "              " + usdVal.ToString("n2"));

                        //Calculate conversions using increment value
                        cadVal = cadVal + increment;
                    }
                else
                    Console.WriteLine("The increment value should be between 0 and 25.");
                
                Console.WriteLine("Would you like to enter another CAD value? Type 'y' for yes or 'n' for no.");
                tryAgain = Console.ReadLine();
            }

            catch
            //Process non-integer out of bounds input
            {
                Console.WriteLine("You must enter an integer value.");
                Console.WriteLine("Press any key to exit and try again.");
                Console.ReadKey(true);
            }
        }
    }
}