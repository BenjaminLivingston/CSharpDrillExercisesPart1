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
            Console.WriteLine("Enter your name, please: ");

            // Now read the name entered
            string name = Console.ReadLine();

            // Greet the user with the name that was entered.
            Console.WriteLine("Hellow, " + name);

            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
