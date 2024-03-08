using Question2_Estagio.Questions;
using System;

namespace Question2_Estagio
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            First.FirstQuestion();

            
            
            Console.WriteLine(Second.CheckFibonacci(22));

            Console.WriteLine("Press any key to close the app");
            Console.ReadKey();
        }
    }
}
