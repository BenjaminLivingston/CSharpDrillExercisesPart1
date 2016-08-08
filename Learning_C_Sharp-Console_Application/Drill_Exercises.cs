using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Learning_C_Sharp_Console_Application
{
    class drillExercises
    {

        // Code being reused for utility purposes
        public void clrScreen()
        {
            Console.WriteLine("\n\nPress any key to continue . . .");
            Console.ReadLine();
            Console.Clear();
            return;
        }



        static void Main(string[] args)
        {

            drillExercises ex = new drillExercises();

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


            // Clear console in between examples
            ex.clrScreen();


            // Overriding Methods Example
            Console.WriteLine("\nThis is an example of overriding a method.");
            Console.WriteLine("\nA class can be made as a child of another class and it");
            Console.WriteLine("will inherit the methods associated with that class.");
            Console.WriteLine("Overriding a method allows a method inherited from a parent");
            Console.WriteLine("to be altered but still have the same method name.");
            Console.WriteLine("For example, let's create two employee classes.  One is a");
            Console.WriteLine("line cook in a restaurant and the other is a server.  Servers");
            Console.WriteLine("receive tips and these are reflected in their pay at this");
            Console.WriteLine("restaurant.  A method to calculate pay will be overridden");
            Console.WriteLine("so that the payment amount for the server reflects the tips.");

            // Create the two employee examples
            Employee kitchenStaff1 = new Employee("Sarah", 12.5);
            Server frontStaff1 = new Server("Jorge",9.25, 435.65);

            // Return example of overrides
            Console.WriteLine("\nThe line cook, " + kitchenStaff1.empName +
                ", earned: " + kitchenStaff1.getTotalPay(34.5) + " during the pay period.");

            Console.WriteLine("\nThe server,  " + frontStaff1.empName +
                ", earned: " + frontStaff1.getTotalPay(26) + " during the pay period.");


            // Clear console in between examples
            ex.clrScreen();

        }

        
        // Overloading Methods
        public int mathOperation(int num1, int num2)
        {
            return num1 * num2;
        }

        public double mathOperation(double num1, double num2)
        {
            return num1 * num2;
        }



        // Overriding Methods Classes
        public class Employee
        {
            public string empName;
            public double hrRate;
            protected double payAmount;

            // Employee construtor
            public Employee(string empName, double hrRate)
            {
                this.empName = empName;
                this.hrRate = hrRate;
            }

            // Get Total payment method -- virtual to allow overriding
            public virtual double getTotalPay(double hoursWorked)
            {
                payAmount = hrRate * hoursWorked;
                return payAmount;
            }
        }

        // Server class derived from Employee
        public class Server : Employee
        {
            private double tips;

            public Server(string empName, double hrRate,
                double tips) : base(empName, hrRate)
            {
                this.tips = tips;
            }

            // Override getTotalPay
            public override double getTotalPay(double hoursWorked)
            {
                payAmount = hrRate * hoursWorked;
                return payAmount + tips;
            }
        }



    }
}
