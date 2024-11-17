using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("What's your first name? ");
       string first_name = Console.ReadLine();

       Console.WriteLine("what's your last name? ");
       string last_name = Console.ReadLine();

       Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    



    }
}