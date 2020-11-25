using System;

namespace Pythagorean
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Welcome, this program is using the pythagoras formula,
             with some user interaction. ( I hate C#)
             made by: David Barkanyi
             */

            //Welcome msg
            Console.WriteLine("Welcome to my program. This will calculate Pythagorean");

            //Declare vars 
            double aSide, bSide, cSide;
            bool isRunning = true;
            string exitAnswer = null;

            //Loop for menu
            while (isRunning == true) {

                Console.WriteLine("Which side you're looking for ? ");
                Console.WriteLine(
                    "1. --> Hypotenuse  " + '\n'
                  + "2. --> Leg");

                int userSelect = Convert.ToInt32(Console.ReadLine());

                //Cases below

                switch (userSelect) { 

                case 1:

                    Console.WriteLine("Please give me the A side");
                    aSide = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please give me the B side");
                    bSide = double.Parse(Console.ReadLine());
                    cSide = ((aSide * 2) + (bSide * 2)) / 2;
                    Console.WriteLine("x = (" + aSide * 2 + " + " + bSide * 2 + ") /2");
                    Console.WriteLine("The length of the side is: " + cSide);
                    break;

                case 2:
                
                    Console.WriteLine("Please give me the hypotenuse side");
                    cSide = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please give me the known leg side");
                    bSide = double.Parse(Console.ReadLine());
                    aSide = ((cSide * 2) - (bSide * 2)) / 2;
                    Console.WriteLine("x = " + cSide * 2 + " - " + bSide * 2 + ") /2");
                    Console.WriteLine("The length of the side is: " + aSide);
                    break;


                default:
                    Console.WriteLine("Something seems wrong, try again");
                    break;
                }

                //Exit option

                while(exitAnswer != "y" || exitAnswer != "n")
                {

                    Console.WriteLine("Would you like to exit the program? Y / N ");

                    exitAnswer = Console.ReadLine().ToLower();
                    if (exitAnswer == "y")
                    {
                        isRunning = false;
                        break;
                    }
                    if (exitAnswer == "n")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input, please try again");
                    }
                }
            }
        }
    }
}
