using System;

namespace Question2_Estagio.Questions
{
    internal class First
    {
        public static void FirstQuestion()
        {
            int indice = 13;
            int soma = 0;
            int k = 0;
            Console.WriteLine("1ª Questão\n");
            while (k < indice)
            {
                k++;
                Console.WriteLine($"{soma + k} = {soma} + {k}");
                soma += k;

            }
            Console.WriteLine($"\nAo final do processamento, a váriavel soma terá o valor: {soma}");

        }
    }
}
