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
            if (num == 0) return 0;
            else if (num == 1) return 1;
            return FibonacciSequence(num - 1) + FibonacciSequence(num - 2);
        }

        public static bool CheckFibonacci(int num)
        {
            int sum = 0;
            for (int i = 0; i <= num; i++)
            {
                sum = FibonacciSequence(i);
                if (sum >= num) break;
            }
            return (sum == num);
        }
        
    }
}
