using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Question2_Estagio.Functions;

namespace Question2_Estagio.Questions
{
    internal class Third
    {
        public static void A()
        {
            
            Console.WriteLine("A)\n");
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n");
        }

        public static void B()
        {
            Console.WriteLine("B)\n");
            for (int i = 1; i < 20; i++)
            {
                Console.Write(Math.Pow(2, i) + " ");
            }
            Console.WriteLine("\n");
        }

        public static void C()
        {
            Console.WriteLine("C)\n");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(i*i + " ");
            }
            Console.WriteLine("\n");
        }

        public static void D()
        {
            Console.WriteLine("D)\n");
            for (int i = 1; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(Math.Pow(i, 2) + " ");
                }
            }
            Console.WriteLine("\n");
        }

        public static void E()
        {
            Console.WriteLine("E)\n");
            for (int i = 1; i < 20; i++)
            {
                Console.Write(Second.FibonacciSequence(i) + " ");
            }
            Console.WriteLine("\n");
        }

        public static void F()
        {
            Console.WriteLine("F)\n");
            for (int i = 0; i < 210; i++)
            {
                char extensive = IntToExtensive.BusqueExtenso(i, "").ToCharArray()[0];
                if (extensive.Equals('D')) Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
