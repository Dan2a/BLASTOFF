
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLogicoBLASTOFF
{
    class ConversaoGraus
    {
        static void Main(String[] args)
        {
            double f = 0;
            double c = 0;

            Console.Write("Entre com a temperatura em graus celsius:");
            c = Convert.ToInt32(Console.ReadLine());
            f = (c * 9 / 5) + (32);

            Console.WriteLine(c + "°C equivalente a " + f + "°F");
        }
    }
}
