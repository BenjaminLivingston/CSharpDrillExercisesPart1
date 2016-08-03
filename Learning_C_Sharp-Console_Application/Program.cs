using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Public methods

#endregion Public methods

namespace Learning_C_Sharp_Console_Application
{
    class Program
    {
        // This is where the program starts.
        static void Main(string[] args)
        {

            // Prompt user to enter a name
            Console.Write("Please enter your name: ");

            // Now read the name entered
            string name = Console.ReadLine();

            // Greet the user with the name that was entered.
            Console.WriteLine("\nThank you!. Hello " + name + ".\n");


            /*
                    Sample Variables
             */

            char grade = 'A';
            Console.WriteLine("\n" + name + ", you have received a grade of " + grade + " on C#.\n");

            // Integer with a max number of 2,147,483,647
            int maxInt = int.MaxValue;

            // Long with a max number of 9,223,372,036,854,775,807
            long maxLong = long.MaxValue;

            // Decimal has a maximum value of 79,228,162,514,264,337,593,543,950,335
            // If bigger is needed use BigInteger
            decimal maxDec = decimal.MaxValue;

            // A float is a 32 bit number with a maxValue of 3.402823E+38 with 7 decimals
            // of precision
            float maxFloat = float.MaxValue;

            // A double is a 32 bit number float with a maxValue of 1.797693134E +308 
            // with 15 decimals of precition
            double maxDouble = double.MaxValue;

            // Print out the samples:
            Console.WriteLine("Max Int: " + maxInt);
            Console.WriteLine("Max Long: " + maxLong);
            Console.WriteLine("Max Decimal: " + maxDec);
            Console.WriteLine("Max Float: " + maxFloat);
            Console.WriteLine("Max Double: " + maxDouble);


            var anotherName = "George";
            // This would now be an error because a string was assigned with the var
            // anotherName = 2;
            // So, get the type
            Console.WriteLine("\nanotherName variable is a {0}", anotherName.GetTypeCode() + "\n\n");



            /*
                    MATH
             */
            Console.WriteLine("5 + 3     = " + (5 + 3));
            Console.WriteLine("5 - 3     = " + (5 - 3));
            Console.WriteLine("5 x 3     = " + (5 * 3));
            Console.WriteLine("5 ÷ 3     = " + (5 / 3));
            Console.WriteLine("5.2 MOD 3 = " + (5.2 % 3));

            int i = 0;
            Console.WriteLine("i++       = " + (i++));
            Console.WriteLine("++i       = " + (++i));
            Console.WriteLine("i--       = " + (i--));
            Console.WriteLine("--i       = " + (--i));

            Console.WriteLine("i+=3      = " + (i+=3));
            Console.WriteLine("i-=2      = " + (i-=2));
            Console.WriteLine("i*=2      = " + (i*=2));
            Console.WriteLine("i/=2      = " + (i/=2));
            Console.WriteLine("i%=2      = " + (i%=2));

            // Casting
            double pi = 31.4;
            int intPi = (int)pi;

            // Other Math functions
            // Acos, Asin, Atan, Atan2, Cos, Cosh, Exp, Log, Sin, Sinh, Tan, Tanh
            double number1 = 10.5;
            double number2 = 15;

            Console.WriteLine("Math.Abs(First Number)                  = " + (Math.Abs(number1)));
            Console.WriteLine("Math.Ceiling(First Number)              = " + (Math.Ceiling(number1)));
            Console.WriteLine("Math.Floor(First Number)                = " + (Math.Floor(number1)));
            Console.WriteLine("Math.Max(First Number & Second Number)  = " + (Math.Max(number1, number2)));
            Console.WriteLine("Math.Min(First Number & Second Number)  = " + (Math.Min(number1, number2)));
            Console.WriteLine("Math.Pow(First Number to the 2nd power) = " + (Math.Pow(number1, 2)));
            Console.WriteLine("Math.Round(First Number)                = " + (Math.Round(number1)));
            Console.WriteLine("Math.Sqrt(First Number)                 = " + (Math.Sqrt(number1)));

            Random rand = new Random();
            Console.WriteLine("\nA random Number between 1 and 10 is " + (rand.Next(1,11)));


            /*
                    CONDITIONALS
             */

            // Relational Operators: > < >= <= == !=
            // Logical Operators: && || ^ !
            int age = 17;

            if ((age >= 5) && (age <=7))
            {
                Console.WriteLine("\nYou should attend elementary school.");
            }else if ((age > 7) && (age <= 13))
            {
                Console.WriteLine("\nYou should attend middle school.");
            }else if ((age > 13) && (age <= 18))
            {
                Console.WriteLine("\nYou should attend high school.");
            }else if (age < 5)
            {
                Console.WriteLine("\nYou are not old enough to attend school.");
            }else
            {
                Console.WriteLine("\nYou do not have to attend school anymore.");
            }

            if ((age < 14) || (age > 67))
            {
                Console.WriteLine("\nYou do not need to work.");
            }


            bool canVote = (age >= 18) ? true : false;
            if (canVote == true)
            {
                Console.WriteLine("\nYou can legally vote.");
            }else
            {
                Console.WriteLine("\nYou cannot legally vote.");
            }


            switch(age)
            {
                case 0:
                    Console.WriteLine("\nInfant");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("\nToddler");
                    break;
                //goto Cute;
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                    Console.WriteLine("\nChild");
                    break;
                default:
                    Console.WriteLine("\nAdult");
                    break;
            }

            /*
             can use goto Cute in switch statement but commenting out for now
             Cute:
                Console.WriteLine("Toddlers are cute.");
             */



            /*
             *      LOOPING
             */
            // If i wasn't already declared then below would be int i = 0 not just i
            i = 0;

            while (i < 10)
            {
                if (i == 7)
                {
                    i++;
                    continue;
                }
                
                if (i == 9)
                {
                    break;
                }

                if ((i % 2) > 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }


            string guess;

            do
            {
                Console.WriteLine("Guess a Number ");
                guess = Console.ReadLine();

            } while (!guess.Equals("15"));


            // If i wasn't already declared then below would be int i = 0 not just i
            for (i = 0; i<10; i++)
            {
                if ((i % 2) > 0)
                {
                    Console.WriteLine(i);
                }
            }



            string randStr = "Here are some random characters";

            foreach(char c in randStr)
            {
                Console.WriteLine(c);
            }



            /*
             *      WORKING WITH STRINGS
             */





            // Wait for user to acknowledge the results.
            Console.WriteLine("\n\nPress Enter to terminate...");
            Console.Read();
        }
    }
}
