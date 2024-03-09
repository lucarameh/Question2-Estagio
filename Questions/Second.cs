using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2_Estagio.Questions
{
    internal class Second
    {
         
        public static int FibonacciSequence(int num)
        {
            if (num <= 1) return num;
            return FibonacciSequence(num - 1) + FibonacciSequence(num - 2);
        }

        public static void CheckFibonacci()
        {
            Console.WriteLine("\n\n2ª Questão\n");
            Console.Write("Digite um número: ");
            int.TryParse(Console.ReadLine(), out int num);

            for (int i = 0; i <= num; i++)
            {
                if (FibonacciSequence(i) == num) { Console.WriteLine($"\n{num} is a Fibonacci number\n\n"); break; }
                if (FibonacciSequence(i) > num) { Console.WriteLine($"\n{num} is not a Fibonacci number\n\n"); break; };
            }
            
        }
        
    }
}
