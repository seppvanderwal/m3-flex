using System;

class Program
{
    static void Main(string[] args)
    {
        string message = "Hello World";
        foreach (char c in message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(c);
            System.Threading.Thread.Sleep(100); 
        }
    }
}