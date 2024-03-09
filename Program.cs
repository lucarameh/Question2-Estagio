using Question2_Estagio.Functions;
using Question2_Estagio.Questions;
using System;

namespace Question2_Estagio
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            First.FirstQuestion();
            Next.NextQuestion();

            Second.CheckFibonacci();
            Next.NextQuestion();

            Console.WriteLine("3ª Questão");
            Third.A();
            Next.NextLetter();
            Third.B();
            Next.NextLetter();
            Third.C();
            Next.NextLetter();
            Third.D();
            Next.NextLetter();
            Third.E();
            Next.NextLetter();
            Third.F();
            Next.NextQuestion();
            

            new Fourth();
            Next.NextQuestion();

            Console.Write("5ª Questão\nEscreva uma frase: ");
            Fifth.ReverseString(Console.ReadLine());
            

            Console.WriteLine("Press any key to close the app");
            Console.ReadKey();

        }
    }
}
