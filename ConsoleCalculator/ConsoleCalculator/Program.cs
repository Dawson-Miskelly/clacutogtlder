using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Console Calculator";

            int intUserChoice;

            System.Console.Write("Please choose one of the following options: \n\n");
            System.Console.WriteLine("\t1) Add ");
            System.Console.WriteLine("\t2) Sub ");
            System.Console.WriteLine("\t3) Mult ");
            System.Console.WriteLine("\t4) Div ");
            intUserChoice = Convert.ToInt32(System.Console.ReadLine());

            if (intUserChoice == 1)
            {
                Add();
            }
            else if (intUserChoice == 2)
            {

            }
            else if (intUserChoice == 3)
            {

            }
            else if (intUserChoice == 4)
            {

            }
            else
            {

            }

        }

        public static void Add()
        {
            double dblNumberOne;

            double dblNumberTwo;

            double dblAnswer;

            System.Console.Write("Enter number one: ");
            dblNumberOne = Convert.ToDouble(System.Console.ReadLine());

            System.Console.WriteLine("Enter number two: ");
            dblNumberTwo = Convert.ToDouble(System.Console.ReadLine());

            dblAnswer = dblNumberOne + dblNumberTwo;

            System.Console.WriteLine(dblNumberTwo + " + " + dblNumberTwo + " = " + dblAnswer);
            System.Console.ReadKey();
        }

        public static void Sub()
        {
            double dblNumberOne;

            double dblNumberTwo;

            double dblAnswer;

            System.Console.Write("Enter number one: ");
            dblNumberOne = Convert.ToDouble(System.Console.ReadLine());

            System.Console.WriteLine("Enter number two: ");
            dblNumberTwo = Convert.ToDouble(System.Console.ReadLine());

            dblAnswer = dblNumberOne + dblNumberTwo;

            System.Console.WriteLine

        }

    }
}
