using System;

class Program
{
    static void Main(string[] args)
    {
        int randomNumber = GenerateRandomNumber();
        Console.WriteLine("The generated random number is: " + randomNumber);
    }

    static int GenerateRandomNumber()
    {
        Random rand = new Random();
        return rand.Next(1, 101); 
    }
}