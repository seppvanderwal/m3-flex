using System;

class Program
{
    static void Main()
    {
        string String = "Hello, world!";
        FirstFunction(String);
    }

    static void FirstFunction(string str)
    {
        int Int = 5;
        SecondFunction(str, Int);
    }

    static void SecondFunction(string str, int num)
    {
        bool Bool = true;
        ThirdFunction(str, Bool, num);
    }

    static void ThirdFunction(string str, bool flag, int num)
    {
        Console.WriteLine("The string argument is: " + str);
        Console.WriteLine("The boolean argument is: " + flag);
        Console.WriteLine("The integer argument is: " + num);
    }
}
