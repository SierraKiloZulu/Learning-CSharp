using System;

public class Program
{
    public static void Main(string[] args) //Entry point for program; defines function; Anything in Main runs
    {
        //Variables Extended
        //Primitive Types
        //whole numbers/signed
        //int literals, defaults to declared var unless literal is declared (l,i,s,u)
        long lngWholeNumber = -0;           //8     bytes 00000000 00000000 00000000 00000000 00000000 00000000 00000000 00000000 
        int wholeNumber = -2_147_483_648;   //4     bytes 00000000 00000000 00000000 00000000
        short shrtWholeNumber = -32_767;    //2     byte 00000000 00000000
        sbyte byteWholeNumber = -127;       //1     byte 00000000

        //whole numbers/unsigned
        ulong unsigLong = 0;                //8     bytes 00000000 00000000 00000000 00000000 00000000 00000000 00000000 00000000 00000000
        uint unsigInt = 0;                  //4     bytes 00000000 00000000 00000000 00000000
        ushort unsigShort = 0;              //2     byte 00000000 00000000
        byte unsigByte = 0;                 //1     byte 00000000

        bool trfBool = false;               //1     byte 00000000
                                            //  Lowest operating value processor can handle is a byte


        //decimal numbers/fractions
        //float literals, must be declared (f, d, m)
        float fltPoint = 1.1f;              //4     bytes 00000000 00000000 00000000 00000000
        double dblPoint = 3.14159d;         //8     bytes 00000000 00000000 00000000 00000000 00000000 00000000 00000000 00000000
        decimal decPoint = 3.14159m;        //16    bytes 00000000 00000000 00000000 00000000 00000000 00000000 00000000 00000000

        //string
        //sizes depend on encoding UTF-8, ASCII etc
        //csharp usually uses UTF-8
        string word = "string";             //words
        char character = 'c';               //character

        //Converting Types
        //Casting (var) before value
        //If casting larger value to smaller value, information is lost.
        float toConvertFlt = 1.8f;
        int convertedInt = (int) toConvertFlt; //Typically Wrong; short hand for rounding down
        int corrConvertInt = (int) MathF.Round(toConvertFlt); //Typically correct way to round up/down value
        int corrCeilingInt = (int) MathF.Ceiling(toConvertFlt);
        int corrFloorInt = (int) MathF.Floor(toConvertFlt);



        //Arrays
        //Arrays are different types from Primitives
        //Arrays are a type of simple datastructure; typically used iterated over but has other uses
        int[] intArray = new int[3]; //Arrays will default values where possible; numbers = 0, char&string = \0



        for (int i = 0; i < intArray.Length; i++) 
        {
            intArray[i] = corrConvertInt;
        }
        






    }
}