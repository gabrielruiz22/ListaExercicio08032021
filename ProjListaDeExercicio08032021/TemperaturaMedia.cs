using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjListaDeExercicio08032021
{
    class TemperaturaMedia
    {
        static void Main(string[] args)
        {
            double[] array = new double[5];
            // double[] array2 = new double [5];
            double maior = 0, menor = 0, media = 0;

            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Informe a " + (i + 1) + "ª temperatura: ");
                array[i] = double.Parse(Console.ReadLine());
                media += array[i];
            }
            for (int j = 0; j <= 4; j++)
            {
                if (j == 0)
                {
                    maior = array[j];
                    menor = array[j];
                }
                if (array[j] > maior)
                {
                    maior = array[j];
                }
                if (array[j] < menor)
                {
                    menor = array[j];
                }
            }
            media = (media / 5);
            Console.WriteLine("A maior temp foi: " + maior);
            Console.WriteLine("A menor temp foi: " + menor);
            Console.WriteLine("A media da temp foi: " + media);

            Console.ReadKey();
        }
    }
}
