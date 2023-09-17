using System;

public class TrianglesCLI
{
    public static void Main(string[] args) //Entry point for program; defines function; Anything in Main runs
    {
        /*
        1.Ask the user for a value between 3 and 10
        2.Draw a right angle triangle in the console
        3.The height and width should be determined by user input
        4. if the user does not enter valid input the program should ask the user to reinput a value
        5. if the user fails to input a proper value more than 5 times the program should tell them and then exit

        example:
        #
        ##
        ###
        */
        //variable declarations
        int wrongInputs = 0;
        int triangleSize;

        // Ask the user for a value between 3 and 10
        Console.WriteLine("Hello User, Please provide the width of the triangle");
        //compare to current value of wrongInputs
        while (wrongInputs < 5)
        {
            string input = Console.ReadLine(); //Take input from user
            bool isInt = int.TryParse(input, out triangleSize);


            if (isInt == true && triangleSize <= 10 && triangleSize >= 3)
            {
                for (int y = 0; y < triangleSize; y++)
                {
                    for (int x = 0; x <= y; x++)
                    {
                        Console.Write("#");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine($"Your triangle is {triangleSize} tall and {triangleSize} wide.");
                break;
            }
            else if (wrongInputs < 4)
            {
                Console.WriteLine("Input is not a valid input, please input an integer between 3 and 10.");
                wrongInputs++;
            }
            else
            {
                Console.WriteLine("Please learn how to NUMBER. KTHXBAI");
                wrongInputs++;
            }
        }


    }
}
