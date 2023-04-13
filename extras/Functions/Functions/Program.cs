using System;

class Program
{
    static void Main()
    {
        int Int = 5;
        string String = "Hello, world!";
        PrintArguments(Int, String);
    }

    static void PrintArguments(int num, string str)
    {
        Console.WriteLine("The integer argument is: " + num);
        Console.WriteLine("The string argument is: " + str);
    }
}