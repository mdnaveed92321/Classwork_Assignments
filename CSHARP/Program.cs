using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace firstprojcsharp
{
    public class Excan
    {
        public string fname;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Console I/O *****");
            //GetUserData();
            //LocalVarDeclarations();
            //NewingDataTypes();
            //FormatNumericalData();
            //ObjectFunctionality();
            //DataTypeFunctionality();
            //BasicStringFunctionality();
            //StringConcatenation();
            //StringsAreImmutable();
            //EscapeChars();
            //FunWithStringBuilder();
            //StringInterpolation();
            //ForAndForEachLoop();
            //VarInForeachLoop();
            //ExecuteWhileLoop();
            //ExecuteIfElse();
            //ExecuteSwitchOnString();
            //SwitchOnEnumExample();
            //DeclareImplicitVars();
            //QueryOverInts();
            //ArrayOfObjects();
            //GetStringArray();
            PassAndReceiveArrays();
            //SystemArrayFunctionality();
            Console.ReadLine();
        }

        #region Get user data
        private static void GetUserData()
        {

            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string userAge = Console.ReadLine();

            ConsoleColor prevbackColor = Console.BackgroundColor; 
            Console.BackgroundColor = ConsoleColor.Green;
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow; 
            Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);

            // Restore previous color.
            Console.ForegroundColor = prevColor; // White
            Console.BackgroundColor = prevbackColor; // Black
            Console.WriteLine("Thank you");
        }
        #endregion

        #region Format numerical data
        private static void FormatNumericalData()
        {
            Console.WriteLine("The value 99999 in various formats:");
            Console.WriteLine("c format: {0:c}", 99999);      // currency
            Console.WriteLine("d9 format: {0:d9}", 99999);    // decimal with padding
            Console.WriteLine("f3 format: {0:f3}", 99999);    // fixed-point
            Console.WriteLine("n format: {0:n}", 99999);      // number with commas


            Console.WriteLine("E format: {0:E}", 99999);      // exponential
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);      // hexadecimal (uppercase)
            Console.WriteLine("x format: {0:x}", 99999);      // hexadecimal (lowercase)
        }
        #endregion
        static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Data Declarations:");
            int myInt = 0;

            string myString;
            myString = "This is my character data:Naveed";

            bool b1 = true, b2 = false, b3 = b1;
            System.Boolean b4 = false;

            Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}",
                myInt, myString, b1, b2, b3, b4);
            Console.WriteLine();
        }
        static void NewingDataTypes()
        {
            Console.WriteLine("=> Using new to create variables:");
            bool b = new bool();        // Set to false.
            int i = new int();          // Set to 0.
            double d = new double();    // Set to 0.0
            DateTime dt = new DateTime(); // Set to 1/1/0001 12:00:00 AM
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine();
        }
        #region Test Object functionality
        static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Functionality:");

            int x = 12;
            Console.WriteLine("X variable contains{0}", x);
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();
        }
        #endregion
        static void DataTypeFunctionality()
        {
            double a = -10;
            double b = 0;
            double ans = a / b;

            Console.WriteLine(ans);

            Console.WriteLine("=> Data type Functionality:");
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}",
              double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}",
              double.NegativeInfinity);
            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
            Console.WriteLine("bool.sizeof: {0}", sizeof(bool));
            Console.WriteLine();
        }
        #region String basics
        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality:");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y?: {0}",
                firstName.Contains("y"));
            Console.WriteLine("New first name: {0}", firstName.Replace("dy", ""));
            Console.WriteLine();
        }
        #endregion
        #region Concatenation
        static void StringConcatenation()
        {
            Console.WriteLine("=> String concatenation:");
            string s1 = "Programming the ";
            string s2 = "Psychobril (PTP)";
            s2 = s1 + s2;
            Console.WriteLine(s2);
        }
        #endregion

        #region Immutable test
        static void StringsAreImmutable()
        {
            // Set initial string value.
            string s1 = "This is my string.";
            Console.WriteLine("s1 = {0}", s1);
            s1 = s1 + " some more addition to string ";
            Console.WriteLine("s1 = {0}", s1);

            // Uppercase s1?
            string upperString = s1.ToUpper();
            Console.WriteLine("upperString = {0}", upperString);

            // Nope! s1 is in the same format!
            Console.WriteLine("s1 = {0}", s1);

            string s2 = "My other string";
            s2 = "New string value";
            Console.WriteLine(s2);
        }
        #endregion
        static void EscapeChars()
        {
            Console.WriteLine("=> Escape characters: \a");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a";
            Console.WriteLine(strWithTabs);

            Console.WriteLine("Everyone loves \"Hello World\" \a ");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\\ \a"); // c:\My
            Console.WriteLine("All finished.\n\n\a ");
            Console.WriteLine();

            // The following string is printed verbatim
            // thus, all escape characters are displayed.
            Console.WriteLine(@"C:\MyApp\bin\Debug\");

            // White space is preserved with verbatim strings.
            string myLongString = @"This is a very
        very
            very         long string";
            Console.WriteLine(myLongString);
            Console.WriteLine();
            Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");
        }
        #region Fun with StringBuilder
        static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using the StringBuilder:");

            // Make a StringBuilder with an initial size of 256.
            StringBuilder sb = new StringBuilder("* Fantastic Games *");

            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("\nBeyond Good and Evil");
            sb.AppendLine("\nDeus Ex 2");
            sb.AppendLine("\nSystem Shock");
            Console.WriteLine(sb.ToString());

            sb.Replace("2", " Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
            // sb.Console.WriteLine();
        }
        #endregion
        #region String interpolation
        static void StringInterpolation()
        {
            // Some local variables we will plug into our larger string
            int age = 14;
            string name = "Sweety";

            // Using curly bracket syntax.
            string greeting = string.Format("\tHello {0} you are {1} years old.", name.ToUpper(), age);
            Console.WriteLine(greeting);

            // Using string interpolation
            string greeting2 = $"\tHello {name.ToUpper()} you are {age} years old.";
            Console.WriteLine(greeting2);
        }
        #endregion
        #region For / foreach loops
        // A basic for loop.
        static void ForAndForEachLoop()
        {
            // Note! "i" is only visible within the scope of the for loop.
            for (int i = 0; i < 4; i++)//for(;;)
            {
                Console.WriteLine("Number is: {0} ", i);
            }
            // "i" is not visible here.
            Console.WriteLine();
            Excan[] ex = new Excan[4];
            ex[0] = new Excan();
            ex[1] = new Excan(); ex[2] = new Excan(); ex[3] = new Excan();
            ex[0].fname = "Seema";
            ex[1].fname = "Teema";
            ex[2].fname = "Leema";
            ex[3].fname = "Neema";

            for (int x = 0; x < 4; x++)
            {
                Console.WriteLine(ex[x].fname);
            }

            Console.WriteLine();
            foreach (Excan c in ex)
            { Console.WriteLine(c.fname); }


            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            foreach (string c in carTypes)
            { Console.WriteLine(c); }
            Console.WriteLine();

            int[] myInts = { 10, 20, 30, 40 };
            foreach (int i in myInts)
            { Console.WriteLine(i); }

            Console.WriteLine();
        }
        #endregion
        #region Var keyword in foreach
        static void VarInForeachLoop()
        {
            int[] myInts = { 10, 20, 30, 40 };

            // Use "var" in a standard foreach loop.
            foreach (var item in myInts)
            {
                Console.WriteLine("Item value: {0}", item);
            }

            Console.WriteLine();
        }
        #endregion
        #region while loop
        static void ExecuteWhileLoop()
        {
            string userIsDone = "";

            // Test on a lower-class copy of the string.
            while (userIsDone.ToLower() != "yes")
            {
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
                Console.WriteLine("In while loop");
            }
            Console.WriteLine();
        }
        #endregion

        #region do/while loop
        static void ExecuteDoWhileLoop()
        {
            string userIsDone = "";

            do
            {
                Console.WriteLine("In do/while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            } while (userIsDone.ToLower() != "yes"); // Note the semicolon!

            Console.WriteLine();
        }
        #endregion

        #region If/else
        static void ExecuteIfElse()
        {
            // This is illegal, given that Length returns an int, not a bool.
            string stringData = "My textual data";
            if (stringData.Length > 0)
            { Console.WriteLine("string is greater than 0 characters"); }
            else
            { Console.WriteLine("string is not greater than 0 characters"); }
            Console.WriteLine("Hello");
        }
        #endregion

        #region switch statements
        // Switch on a numerical value.
        static void ExecuteSwitch()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.Write("Please pick your language preference: ");

            string langChoice = Console.ReadLine();//in.nextInt()
            int n = int.Parse(langChoice);

            switch (n)
            {
                case 1:
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case 2:
                    Console.WriteLine("VB: OOP, multithreading, and more!");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }
            Console.WriteLine();
        }

        static void ExecuteSwitchOnString()
        {
            Console.WriteLine("C# or VB");
            Console.Write("Please pick your language preference: ");

            string langChoice = Console.ReadLine();
            switch (langChoice)
            {
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case "VB":
                    Console.WriteLine("VB: OOP, multithreading and more!");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }

            Console.WriteLine();
        }

        static void SwitchOnEnumExample()
        {
            Console.Write("Enter your favorite day of the week: ");
            DayOfWeek favDay;
            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                return;
            }
            switch (favDay)
            {
                case DayOfWeek.Friday:
                    Console.WriteLine("Yes, Friday rules!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Another day, another dollar");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Great day indeed.");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Football!!");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Almost Friday...");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("At least it is not Monday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("A fine day.");
                    break;
            }
            Console.WriteLine();
        }
        #endregion
        #region Implicit data typing
        static void DeclareImplicitVars()
        {
            // Implicitly typed local variables.
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";

            // Print out the underlying type.
            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a: {0}", myString.GetType().Name);
        }
        #endregion
        #region LINQ example
        static void QueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            var subset = from i in numbers where i < 10 select i; //select * from numbers where i < 10

            Console.Write("Values in subset: ");
            foreach (var i in subset)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            // Hmm...what type is subset?
            Console.WriteLine("subset is a: {0}", subset.GetType().Name);
            Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
        }
        #endregion
        #region Array of Objects
        static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of Objects:");

            // An array of objects can be anything at all.
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";

            foreach (object obj in myObjects)
            {
                // Print the type and value for each item in array.
                Console.WriteLine("Type: {0}, Value: {1}, ToString output: {2}", obj.GetType(), obj, obj.ToString());
            }

            Console.WriteLine();
        }
        #endregion
        #region Arrays as params and return values
        static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);
        }

        static string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "from", "GetStringArray" };
            return theStrings;
        }

        static void PassAndReceiveArrays()
        {
            Console.WriteLine("=> Arrays as params and return values.");

            // Pass array as parameter.
            int[] ages = { 20, 22, 23, 0 };
            PrintArray(ages);

            // Get array as return value.
            string[] strs = GetStringArray(); // string[] strs = new string[] { "Hello", "from", "GetStringArray" };
            foreach (string s in strs)
            { Console.WriteLine(s); }

            Console.WriteLine();
        }
        #endregion
        #region System.Array functionality
        static void SystemArrayFunctionality()
        {
            Console.WriteLine("=> Working with System.Array:");

            // Initialize items at startup.
            string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

            // Print out names in declared order.
            Console.WriteLine("-> Here is the array:");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                // Print a name
                Console.Write(gothicBands[i] + ", ");
            }

            Console.WriteLine("\n");

            // Reverse them.
            Array.Reverse(gothicBands);
            Console.WriteLine("-> The reversed array:");
            // and print them.
            for (int i = 0; i < gothicBands.Length; i++)
            {
                // Print a name
                Console.Write(gothicBands[i] + ", ");
            }

            Console.WriteLine("\n-> Cleared out all but one...");
            Array.Clear(gothicBands, 1, 2);
            for (int i = 0; i < gothicBands.Length; i++)
            {
                // Print a name
                Console.Write(gothicBands[i] + ", ");
            }

            Console.WriteLine();
        }
        #endregion
    }
}

