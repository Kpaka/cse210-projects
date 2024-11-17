using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is your score?: ");
        string gradeOne = Console.ReadLine();
       int x = int.Parse(gradeOne);
       /*int y = 90;*/

       if (x >= 90)
       {
            Console.WriteLine("Congratulations, You got A!");
       }
       else if (x >= 80)
       {
            Console.WriteLine("Congratulations, You got B");
       }
       else if (x >= 70)
       {
            Console.WriteLine("Congratulation, You got C");
       }
       else if (x >= 60)
       {
            Console.WriteLine("You got D!, this's not a encouraging. Study hard");
       }
       else if (x < 60)
       {
         Console.WriteLine("You need to pay attention to your study, so you can get a better grade");
       }
       else
       {
            Console.WriteLine("Fail");
       }
    }

}