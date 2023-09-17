using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKZ_Console
{
    internal class Samples
    {
        public static void Main(string[] args) //Entry point for program; defines function; Anything in Main runs
        {
            Console.WriteLine("Function Started");

            //Declaration type variableName
            bool isRunning; //bool default value false
            isRunning = true;
            Console.WriteLine(isRunning);

            int numbLegs = 2 + 10; //int default value 0; May be instantiated in line
                                   //int numWrong = true; can not mix types, must input data consistent with type

            if (numbLegs > 0)//only runs if condition is true; all conditions must be true to run
            {
                Console.WriteLine($"{numbLegs} is running");
            }

            bool hasMoreThan10Legs = numbLegs > 10; //Evaluations follow basic arithmetic rules; bool will set to true or false
            bool has10Legs = numbLegs == 10;
            bool hasGreOrEquTo10 = numbLegs >= 10;

            //basic flow control & logic
            //excute top to bottom
            if (hasMoreThan10Legs)
            {
                Console.WriteLine("Has More than 10 Legs");
            }
            else if (has10Legs)
            {
                Console.WriteLine("Has 10 Legs");
            }
            else if (hasGreOrEquTo10)
            {
                Console.WriteLine("Is Greater or Equal To 10");
            }
            else
            {
                Console.WriteLine("Has Less than 10 legs");
            }
            //BOOLEAN LOGIC OPERATIONS
            if (true && false)//basic logic AND operator; will run only if both operations are true
            {

            }
            if (true || false)//basic logic OR operator; will run if either operation is true
            {

            }
            //LOOPS
            //While loop
            int n = 100;
            while (n < 10)
            {
                Console.WriteLine("N IS RUNNING");
                n = n + 1; //shorthand: n += 1; n++
            }
            //Running WHILE n <= 10

            //int i = i + 1; does not work; variables evaluate right side then create variable; liquid then cup not cup then liquid
            //Do While; If function always needs to at least once; do while evaluates conditions AFTER code in loop is run once; while loops evaluates conditions BEFORE running code in loop
            int i = 100;
            do
            {
                Console.WriteLine("I IS RUNNING");
                i++; //longform: i = i + 1; alt: i += 1
            } while (i < 10);
            //whiles and do whiles only checks conditions*
            //For loop
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("X IS RUNNING");
            }
            /*
             * for (declaration of var; condition; incrementor) 
             * {
             * } 
             * incrementor executes after codeblock
            */
            //Switch Case
            //If you have more than 3 cases use switch cases
            int numLight = 6;
            switch (numLight)
            {
                case 3:
                    Console.WriteLine("THERE ARE ONLY 3 LIGHTS");
                    break;
                case 0:
                    Console.WriteLine("I can't see anything");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("There are 6 lights");
                    break;
                default:
                    Console.WriteLine("I DON'T KNOW HOW MANY LIGHTS THERE ARE!!! AAAAAAA");
                    break;
            }

            //int.Parse(input);
            //bool itWorked = int.TryParse(input, out int inputInt);
        }
    }
}
