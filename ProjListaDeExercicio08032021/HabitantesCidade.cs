using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjListaDeExercicio08032021
{
    class HabitantesCidade
    {
        static void Main(string[] args)
        {
            double[] filhos = new double[5];
            double[] salario = new double[5];
            double mediaSalario = 0, mediaFilho = 0, maior = 0, menor150 = 0, perc = 0;


            for (int i = 0; i < 4; i++)
            {
                Console.Write("Informe seu salario: ");
                salario[i] = double.Parse(Console.ReadLine());
                mediaSalario += salario[i];

                Console.Write("Informe quantos filhos tem: ");
                filhos[i] = double.Parse(Console.ReadLine());
                mediaFilho += filhos[i];

                if (salario[i] < 150)
                {
                    menor150 += 1;
                    perc = (menor150 * 100) / 4;
                }
            }

            for (int j = 0; j < 4; j++)
            {
                if (salario[j] >= maior)
                {
                    maior = salario[j];
                }
            }
            mediaFilho = mediaFilho / 4;
            mediaSalario = mediaSalario / 4;

            Console.WriteLine("\nO maior salario foi: " + maior);
            Console.WriteLine("A media de filho foi: " + mediaFilho);
            Console.WriteLine("A media de salario foi: " + mediaSalario);
            Console.WriteLine("A porcentagem de pessoas que ganham menos de 150 foi: " + perc + "%");
            Console.ReadKey();
        }
    }
}
