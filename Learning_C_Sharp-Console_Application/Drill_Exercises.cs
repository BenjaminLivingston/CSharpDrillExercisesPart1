using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Learning_C_Sharp_Console_Application
{
    class Drill_Exercises
    {

        // Overloading Methods Example
        public int mathOperation(int num1, int num2)
        {
            return num1 * num2;
        }

        public double mathOperation(double num1, double num2)
        {
            return num1 * num2;
        }
        
        

        // Overriding Methods Example




        static void Main(string[] args)
        {

            Drill_Exercises ex = new Drill_Exercises();

            // Overloading Methods Example
            Console.WriteLine("\nThis is an example of overloading a method.");
            Console.WriteLine("\nOverloading a method allows you to use the same method name with");
            Console.WriteLine("differing datatypes for the parameters/arguments.  For example, you");
            Console.WriteLine("can use the same method to do the following multiplication with");
            Console.WriteLine("whole numbers (integers) or numbers with decimals (floats).");

            int integer1 = 5;
            int integer2 = 4;
            int integer3;
            integer3 = ex.mathOperation(integer1, integer2);
            Console.WriteLine("\n\nInteger Example: ");
            Console.WriteLine("{0}x{1} is equal to {2}", integer1, integer2, integer3);

            double float1 = 5.25;
            double float2 = 4.3;
            double float3;
            float3 = ex.mathOperation(float1, float2);
            Console.WriteLine("\n\nFloat Example: ");
            Console.WriteLine("{0}x{1} is equal to {2}", float1, float2, float3);


            // Clear console intbetween examples
            ex.clrScreen();


            // Overriding Methods Example
            Console.WriteLine("\nThis is an example of overriding a method.");





            // Wait for user to acknowledge the results.
            Console.WriteLine("\n\nPress any key to continue . . .");
            Console.Read();

        }


       


        // Code being reused for utility purposes
        public void clrScreen()
        {
            Console.WriteLine("\n\nPress any key to continue . . .");
            Console.Read();
            Console.Clear();
            return;
        }

       


    }
}
