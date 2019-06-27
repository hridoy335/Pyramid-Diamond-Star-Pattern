using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, rows;
            rows = 5;
            for (i = 1; i < rows; i++)
            {
                for (j = i; j < rows; j++)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("\n");
            }

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <=(rows*2)-(2*i-1); j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("\n");
            }

            Console.ReadLine();
        }
    }
}
