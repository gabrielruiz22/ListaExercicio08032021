using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjListaDeExercicio08032021
{
    class ValoresDiferentes
    {
        static void Main(string[] args)
        {
            double N1 = 0, N2 = 0, N3 = 0;

            Console.Write("Informe o primeiro Nº: ");
            N1 = double.Parse(Console.ReadLine());

            Console.Write("Informe o segundo Nº: ");
            N2 = double.Parse(Console.ReadLine());
            while (N1 == N2)
            {
                Console.WriteLine("O segundo numero não pode ser igual ao primeiro");
                Console.Write("Informe o segundo Nº: ");
                N2 = double.Parse(Console.ReadLine());
            }

            Console.Write("Informe o terceiro Nº: ");
            N3 = double.Parse(Console.ReadLine());


            while (N2 == N3 || N1 == N3)
            {
                Console.WriteLine("O terceiro numero não pode ser igual ao primeiro/segundo");
                Console.Write("Informe o terceiro Nº: ");
                N3 = double.Parse(Console.ReadLine());
            }


            if (N1 > N2 && N1 > N3)
            {
                Console.Write("O 1º nº é o maior: " + N1);
            }
            else if (N2 > N1 && N2 > N3)
            {
                Console.Write("O 2º nº é o maior: " + N2);
            }
            else
            {
                Console.Write("O 3º nº é o maior: " + N3);
            }

            Console.ReadKey();
        }
    }
}
