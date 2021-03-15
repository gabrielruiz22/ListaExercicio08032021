using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjListaDeExercicio08032021
{
    class PesoIdeal
    { 
        static void Main(string[] args)
        {
            string nome;
            int altura, cont = 0;
            char sexo;
            double imc = 0;

            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine();

            do
            {
                Console.Write("Informe sua altura: ");
                altura = int.Parse(Console.ReadLine());
                if(altura < 0)
                {
                    Console.WriteLine("Altura invalida");
                }
            } while (altura < 0);

            do
            {
                Console.Write("Informe seu sexo (M / F): ");
                sexo = char.Parse(Console.ReadLine());
               
                if (sexo.Equals('M') || sexo.Equals('F'))
                {
                    cont++;
                }
                if(cont < 1)
                {
                    Console.WriteLine("Sexo invalido");
                }

            } while (cont < 1);

            if (sexo.Equals('M'))
            {
                imc = (72.7 * altura) - 58;
            }else if (sexo.Equals('F'))
            {
                imc = (62.1 * altura) - 44.7;
            }

            Console.WriteLine("IMC é: " + imc);

            Console.ReadKey();
        }
    }
}
