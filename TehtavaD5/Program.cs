using System;

namespace GreetingApp
{
    class Program
    {
        static string GreetUser(string name)
        {
            // Luo tervehdysviesti käyttäjän nimellä
            string greeting = $"Hei {name}";
            return greeting;
        }

        static void Main(string[] args)
        {
            Console.Write("Syötä nimesi: ");
            string userName = Console.ReadLine();

            // Luo tervehdysviesti ja tulosta se
            string greetingMessage = GreetUser(userName);
            Console.WriteLine(greetingMessage);
        }
    }
}

