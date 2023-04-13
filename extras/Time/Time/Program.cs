using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            System.Threading.Thread.Sleep(1000);
        }
    }
}