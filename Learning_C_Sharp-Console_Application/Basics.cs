using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Public methods

#endregion Public methods

namespace Learning_C_Sharp_Console_Application
{

    // Enum example
    public enum Temperature
    {
        // Can use Freeze = 1 to start numbering at 1, etc instead of 0
        Freeze,
        Low,
        Warm,
        Boil
    }


    class Program
    {

        static void Main(string[] args)
        {

            Temperature micTemp = Temperature.Low;

            switch (micTemp)
            {
                case Temperature.Freeze:
                    Console.WriteLine("Temp is Freezing");
                    break;

                case Temperature.Low:
                    Console.WriteLine("Temp on Low");
                    break;

                case Temperature.Warm:
                    Console.WriteLine("Temp on Warm");
                    break;

                case Temperature.Boil:
                    Console.WriteLine("Temp is Boiling");
                    break;
            }


            // Wait for user to acknowledge the results.
            Console.WriteLine("\n\nPress any key to continue . . .");
            Console.Read();

        }
    }




    /*
    class Animal
    {

        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }

        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.name = "No Name";
            this.sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(double height, double weight, string name, string sound)
        {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        static int numOfAnimals = 0;

        public static int getNumOfAnimals()
        {
            return numOfAnimals;
        }

        // Method
        public string toString()
        {
            return String.Format("{0} is {1} inches tall, wieghts {2} lbs and likes to say {3}.",
                name, height, weight, sound);
        }

        // Method overloading -- allows passing in int or double to method
        public int getSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;
        }

        public double getSum(double num1 = 1, double num2 = 1)
        {
            return num1 + num2;
        }


        static void Main(string[] args)
        {

            Shape rect = new Rectangle(5, 5);
            Shape tri = new Triangle(5, 5);

            Console.WriteLine("Rectangle Area " + rect.area());
            Console.WriteLine("Trinagle Area " + tri.area());

            Rectangle combRect = new Rectangle(5, 5) + new Rectangle(5, 5);

            Console.WriteLine("Combined Rectangle Area " + combRect.area());


            Animal spot = new Animal(15, 10, "Spot", "Woof");

            Console.WriteLine("{0} says {1}", spot.name, spot.sound);

            Console.WriteLine("Number of Animals " + Animal.getNumOfAnimals());

            Console.WriteLine(spot.toString());

            Console.WriteLine(spot.getSum(num2: 1.4, num1: 2.7));

            Animal grover = new Animal
            {
                name = "Grover",
                height = 16,
                weight = 18,
                sound = "Grrrr"
            };


            Dog spike = new Dog();

            Console.WriteLine(spike.toString());

            spike = new Dog(20, 15, "Spike", "Grr", "Chicken");

            Console.WriteLine(spike.toString());


            // Using Generic class
            KeyValue<string, string> superman = new KeyValue<string, string>("", "");

            superman.key = "Superman";
            superman.value = "Clark Kent";


            KeyValue<int, string> samsungTV = new KeyValue<int, string>(0, "");

            samsungTV.key = 12345;
            samsungTV.value = "a 50 in Samsung TV";


            superman.showData();

            samsungTV.showData();





            // Wait for user to acknowledge the results.
            Console.WriteLine("\n\nPress Enter to terminate...");
            Console.Read();

        }
    }




    class Dog : Animal
    {
        public string favFood { get; set; }

        public Dog() : base()
        {
            this.favFood = "No Favorite Food";
        }


        public Dog(double height, double weight, string name, string sound, string favFood) :
            base(height, weight, name, sound)
        {
            this.favFood = favFood;
        }


        new public string toString()
        {
            return String.Format("{0} is {1} inches tall, wieghts {2} lbs and likes to say {3} and eats {4}.",
                name, height, weight, sound, favFood);
        }
    }


    // Abstract class example -- can't instatiate an object out of an abstract class
    abstract class Shape
    {
        public abstract double area();

        public void sayHi()
        {
            Console.WriteLine("Hello");
        }
    }


    //Interface
    public interface ShapeItem
    {
        double area();
    }


    class Rectangle : Shape
    {

        private double length;
        private double width;

        public Rectangle(double num1, double num2)
        {
            length = num1;
            width = num2;
        }

        public override double area()
        {
            return length * width;
        }


        // Example of operator overload
        public static Rectangle operator +(Rectangle rect1, Rectangle rect2)
        {
            double rectLength = rect1.length + rect2.length;
            double rectwidth = rect1.width + rect2.width;

            return new Rectangle(rectLength, rectwidth);
        }
    }


    class Triangle : Shape
    {

        private double theBase;
        private double height;

        public Triangle(double num1, double num2)
        {
            theBase = num1;
            height = num2;
        }

        public override double area()
        {
            return .5 * (theBase * height);
        }
    }



    // Generic Type Example
    class KeyValue<TKey, TValue>
    {
        
        public TKey key { get; set; }
        public TValue value { get; set; }

        public KeyValue(TKey k, TValue v)
        {
            key = k;
            value = v;
        }

        public void showData()
        {
            Console.WriteLine("{0} is {1}", this.key, this.value);
        }

    }
    

        class Program
        {
            static void Exception_Main(string[] args)
            {

                /*
                 *      EXCEPTION HANDLING


                try
                {
                    Console.Write("Divide 10 by ");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine("10 / {0} = {1}", num, (10 / num));
                }

                catch(DivideByZeroException ex)
                {
                    Console.WriteLine("Can't divide by zero.");
                    Console.WriteLine(ex.GetType().Name);
                    Console.WriteLine(ex.Message);
                    // throw new InvalidOperationException("Operation Failed", ex); -- Can throw the exception
                }

                catch(Exception ex)
                {
                    Console.WriteLine(ex.GetType().Name);
                    Console.WriteLine(ex.Message);
                }



                /*
                 *      OBJECTS & CLASSES







                // Wait for user to acknowledge the results.
                Console.WriteLine("\n\nPress Enter to terminate...");
                Console.Read();

            }



            // This is where the program starts.
            static void Basic_Main(string[] args)
            {

                // Prompt user to enter a name
                Console.Write("Please enter your name: ");

                // Now read the name entered
                string name = Console.ReadLine();

                // Greet the user with the name that was entered.
                Console.WriteLine("\nThank you!. Hello " + name + ".\n");


                /*
                        Sample Variables


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




                /*
                 *      LOOPING

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


                // Use \ as an escape to print a character like \" or \\ for two backlashes

                string sampString = "A bunch of random words";

                Console.WriteLine("\nIs empty?: " + String.IsNullOrEmpty(sampString));

                Console.WriteLine("\nIs empty?: " + String.IsNullOrWhiteSpace(sampString));

                Console.WriteLine("\nThe length of the string is: " + sampString.Length);

                Console.WriteLine("\nIndex of bunch: " + sampString.IndexOf("bunch"));

                Console.WriteLine("\n2nd Word: " + sampString.Substring(2, 6));

                string sampString2 = "More random words";

                Console.WriteLine("\nStrings are equal: " + sampString.Equals(sampString2));

                Console.WriteLine("\nStarts with \"A bunch\": " + sampString.StartsWith("A bunch"));

                Console.WriteLine("\nEnds with \"words\": " + sampString.EndsWith("words"));

                // sampString = sampString.Trim();
                // TrimEnd, TrimStart for just triming beginning or end
                sampString = sampString.Replace("words", "characters");
                sampString = sampString.Remove(0, 2);

                string[] names = new string[3] { "Matt", "Joe", "Paul" };

                Console.WriteLine("Name List " + String.Join(", ", names));

                string fmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.567, .56, 1000);

                Console.WriteLine(fmtStr);


                /*
                 *      STRING BUILDER


                StringBuilder sb = new StringBuilder();

                sb.Append("This is the first sentence. ");
                sb.AppendFormat("My name is {0} and I live in {1}", "Sally", "Indiana");

                sb.Replace("a", "e");

                sb.Remove(5, 7);

                Console.WriteLine(sb.ToString());


                /*
                 *      ARRAYS


                // int[] randNumArray;

                int[] randArray = new int[5];

                int[] randArray2 = { 1, 2, 3, 4, 5 };

                Console.WriteLine("Array Length " + randArray2.Length);

                Console.WriteLine("Item 0 " + randArray2[0]);

                // If i wasn't already declared then below would be int i = 0 not just i
                for (i = 0; i < randArray2.Length; i++)
                {
                    Console.WriteLine("{0} : {1}", i, randArray2[i]);
                }

                foreach(int num in randArray2)
                {
                    Console.WriteLine(num);
                }

                Console.WriteLine("Where is 1: " + Array.IndexOf(randArray2, 1));

                string[] otherNames = { "Bob", "Paul", "Sally" };

                string nameStr = string.Join(", ", otherNames);

                string[] nameArray = nameStr.Split(',');


                int[,] multArray = new int[5, 3];

                int[,] multArray2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };


                foreach(int num in multArray2)
                {
                    Console.WriteLine(num);
                }


                for(int x = 0; x < multArray2.GetLength(0); x++)
                {
                    for (int y = 0; y < multArray2.GetLength(1); y++)
                    {
                        Console.WriteLine("{0} | {1} : {2}", x, y, multArray2[x, y]);
                    }
                }




                /*
                 *      LISTS


                List<int> numList = new List<int>();

                numList.Add(5);
                numList.Add(15);
                numList.Add(25);

                int[] numArray = { 1, 2, 3, 4, 5 };
                numList.AddRange(numArray);

                //numList.Clear;

                List<int> numList2 = new List<int>(numArray);

                List<int> numList3 = new List<int>(new int[] { 1, 2, 3, 4 });

                numList.Insert(1, 10);

                numList.Remove(5);

                numList.RemoveAt(2);
                // If i wasn't already declared then below would be int i = 0 not just i
                for (i = 0; i < numList.Count; i++)
                {
                    Console.WriteLine(numList[i]);
                }

                // Get -1 if index isn't found
                Console.WriteLine("4 is in index " + numList3.IndexOf(4));


                Console.WriteLine("5 in list? " + numList.Contains(5));

                List<string> strList = new List<string>(new string[] { "Tom", "Paul" });

                Console.WriteLine("Tom is in the list? " + strList.Contains("tom", 
                    StringComparer.OrdinalIgnoreCase));


                strList.Sort();


                // Wait for user to acknowledge the results.
                Console.WriteLine("\n\nPress Enter to terminate...");
                Console.Read();
            }
        }
        */
}
