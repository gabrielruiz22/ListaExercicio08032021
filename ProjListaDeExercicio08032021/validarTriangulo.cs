using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjListaDeExercicio08032021
{
    class validarTriangulo
    {
        static void Main(string[] args)
        {

            int L1, L2, L3;

            Console.Write("Informe o 1Nº: ");
            L1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o  2Nº: ");
            L2 = int.Parse(Console.ReadLine());

            Console.Write("Informe o  3Nº: ");
            L3 = int.Parse(Console.ReadLine());

            if (L1 < (L2 + L3))
            {
                if (L2 < (L3 + L1))
                {
                    if (L3 < (L1 + L2))
                    {
                        Console.WriteLine("É um triangulo");
                    }
                    else
                    {
                        Console.WriteLine("Não é um triangulo");
                    }
                }
                else
                {
                    Console.WriteLine("Não é um triangulo");
                }
            }
            else
            {
                Console.WriteLine("Não é um triangulo");
            }
            Console.ReadKey();

        }
    }
}
