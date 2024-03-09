using Question2_Estagio.Questions;
using System;

namespace Question2_Estagio
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            First.FirstQuestion();

            Second.CheckFibonacci();

            Console.WriteLine("3ª Questão");
            Third.A();            
            Third.B();            
            Third.C();            
            Third.D();            
            Third.E();            
            Third.F();

            Console.WriteLine("Press any key to close the app");
            Console.ReadKey();

        }
    }
}
