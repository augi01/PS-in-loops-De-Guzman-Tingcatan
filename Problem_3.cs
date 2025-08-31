using System;

class Power
{
    static void Main()
    {
        int baseNum = 2, exponent = 5;
        int result = 1;
        for (int i = 1; i <= exponent; i++)
        {
            result *= baseNum;
        }
        Console.WriteLine(result);
    }
}
