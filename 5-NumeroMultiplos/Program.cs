using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLogicoBLASTOFF
{
    class numerosMultipos
    {
        static void Main()
        {

            string[] valores = new string[2];
            int a;
            int b;

            Console.WriteLine("Verifique se os numeros são múltiplos");
            Console.Write("Digite o 1° numero: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o 2° numero: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
