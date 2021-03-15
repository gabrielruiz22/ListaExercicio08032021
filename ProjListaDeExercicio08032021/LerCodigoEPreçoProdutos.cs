using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjListaDeExercicio08032021
{
    class LerCodigoEPreçoProdutos
    {
        static void Main(string[] args)
        {
            int N;
            double[] vetor = new double[15];
            double media = 0, preco, maior = 0;


            for (int i = 0; i < 15; i++)
            {
                Console.Write("Informe o preço do " + (i + 1) + "º produto: ");
                vetor[i] = double.Parse(Console.ReadLine());
                media += vetor[i];
            }

            for (int j = 0; j < 15; j++)
            {
                if (vetor[j] >= maior)
                {
                    maior = vetor[j];
                }
            }

            media = (media / 15);
            Console.WriteLine("\nO produto mais cara custa: " + maior);
            Console.WriteLine("A media de preço foi: " + media);

            Console.ReadKey();
        }
    }
}
