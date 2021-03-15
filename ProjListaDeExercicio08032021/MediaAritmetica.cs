using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjListaDeExercicio08032021
{
    class MediaAritmetica
    {
        static void Main(string[] args)
        {
            int i, soma = 0, qtd = 0;
            double media = 0;

            for (i = 15; i <= 100; i++)
            {
                soma += i;
                qtd++;
            }

            media = (soma / qtd);
            Console.WriteLine("A média foi: " + media);
            Console.ReadKey();
        }
    }
}
