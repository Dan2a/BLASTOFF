using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLogicoBLASTOFF
{
    class MenorNumero
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Calculora exibir menor numero");
            Console.WriteLine("Digite os 3 valores para saber qual o menor:");
            Console.Write("1°: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("2°: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("3°: ");
            c = Convert.ToDouble(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine("Menor numero é: " + a);
            }
            else if (b < a && b < c)
            {
                Console.WriteLine("Menor numero é: " + b);
            }
            else
            {
                Console.WriteLine("Menor numero é: " + c);
            }
        }
    }
}
