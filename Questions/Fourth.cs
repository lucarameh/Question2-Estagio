using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2_Estagio.Questions
{
    internal class Fourth
    {
        public Fourth()
        {
            Console.WriteLine("4ª Questão\n");
            Console.WriteLine("-Primeiro Ligamos o interruptor 1° e deixamos os outros 2 desligados.");
            Console.WriteLine("-Após um tempo, desligamos o 1° interruptor e ligamos o 2°.");
            Console.WriteLine("-Depois disso, vamos para a sala das lâmpadas");
            Console.WriteLine("-Caso a lâmpada esteja desligada, porém quente, o interruptor 1 a controla, \ncaso ela esteja ligada, o interruptor 2 a controla, caso contrário, \no interruptor 3 a controla.");
            Console.WriteLine("-Voltamos para a sala dos interruptores, desligamos o 2º interruptor e ligamos o 3º");
            Console.WriteLine("-Após isso, voltamos para a sala das lâmpadas e verificamos qual está acessa, assim confirmando qual é controlada pelo 3º interruptor");
            Console.WriteLine("-Desta forma, constatamos todas as associações lâmpadas-interruptores\n");
        }
    }
}
