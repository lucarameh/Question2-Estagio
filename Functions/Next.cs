using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2_Estagio.Functions
{
    internal class Next
    {
        public static void NextQuestion()
        {
            Console.WriteLine("Pressione qualquer tecla para ir para a próxima questão!");
            Console.ReadKey();
            Console.Clear();
        }

        public static void NextLetter()
        {
            Console.WriteLine("Pressione qualquer tecla para ir para a próxima letra!");
            Console.ReadKey();
        }
    }
}
