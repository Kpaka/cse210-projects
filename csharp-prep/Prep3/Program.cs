using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
          Random randomGenerator = new Random();
          int magicWord = randomGenerator.Next(1, 101);

          int guess = -1;

          while (guess != magicWord )
          {
               Console.Write("What is your guess? ");
               guess = int.Parse(Console.ReadLine());
          }
          if (magicWord > guess)
          {
               Console.WriteLine("Higher");
          }
          else if (magicWord < guess)
          {
               Console.WriteLine("Lower");
          }
          else
          {
               Console.WriteLine("You win!");
          }
              
    }
}