using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLogicoBLASTOFF
{
    class CaluloMedia
    {
        static void Main(String[] args)
        {
            double n1, n2, n3, n4, n5;
            double media;

            Console.WriteLine("Calulo de média");
            Console.WriteLine("Digite os 5 valores para calcular a média:");
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            n3 = Convert.ToDouble(Console.ReadLine());
            n4 = Convert.ToDouble(Console.ReadLine());
            n5 = Convert.ToDouble(Console.ReadLine());

            media = (n1 + n2 + n3 + n4 + n5) / 5;

            Console.WriteLine("A média é: " + media);
        }
    }
}
