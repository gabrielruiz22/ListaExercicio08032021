using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjListaDeExercicio08032021
{
    class SomaTotalDezNumeros
    {
        static void Main(string[] args)
        {
            int numero = 0, soma = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Informe o " + i + "Nº: ");
                numero = int.Parse(Console.ReadLine());
                soma = soma + numero;
            }
            Console.WriteLine("A soma de todos os nº foi: " + soma);
            Console.ReadKey();
        }
    }
}
