using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjListaDeExercicio08032021
{
    class LerValoresInteiros
    {
        static void Main(string[] args)
        {
            int N = 1;

            Console.Write("Informe um numero:");
            N = int.Parse(Console.ReadLine());

            while (N == 0)
            {
                Console.WriteLine("O numero tem que ser maior que ZERO!");
                Console.Write("Informe um numero:");
                N = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("\n" + i);
            }

            Console.ReadKey();
        }
    }
}
