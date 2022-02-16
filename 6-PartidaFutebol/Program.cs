using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLogicoBLASTOFF
{
    class PartidaFutebol
    {
        static void Main()
        {
            var dt1 = new DateTime();
            var dt2 = new DateTime();

            Console.WriteLine("Calcule o tempo de duração da partida");

            Console.Write("Insira o horario de inicio da partida (hh:mm:ss):");
            dt1 = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Insira o horario do fim da partida (hh:mm:ss):");
            dt2 = Convert.ToDateTime(Console.ReadLine());

            TimeSpan ts = dt2 - dt1;
            Console.WriteLine("A partida durou: " + ts);

        }
    }
}
