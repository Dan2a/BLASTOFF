using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLogicoBLASTOFF
{
    class MediaConsumoCombustivel
    {
        static void Main(string[] args)
        {
            double quilometragem, litros;
            double media;

            Console.WriteLine("Calculadora de consumo médio de conbustivel pro quilometro ");

            Console.Write("Digite quantidade de quilometros rodados:");
            quilometragem = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite quantos litros foram ultilizados:");
            litros = Convert.ToDouble(Console.ReadLine());

            media = quilometragem / litros;

            Console.WriteLine("A média de litros por quilometros: " + media + " KM/l");
        }
    }
}