using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjListaDeExercicio08032021
{
    class CalculoImpostoCarro
    {
        static void Main(string[] args)
        {
            double valorAutomovelFabrica, valorImpostoGov, valorImpostoDistribuidor;
            int porcentagemImpostos = 45;
            int porcentagemLucroDistribuidor = 28;

            do
            {
                Console.Write("Informe o valor do carro (preço de fabricação): ");
                valorAutomovelFabrica = double.Parse(Console.ReadLine());

                if(valorAutomovelFabrica < 0)
                {
                    Console.WriteLine("valor automovel invalido!");
                }
            } while (valorAutomovelFabrica < 0);

            valorImpostoGov = (valorAutomovelFabrica * porcentagemImpostos) / 100;
            valorImpostoDistribuidor = (valorAutomovelFabrica * porcentagemLucroDistribuidor) / 100;

            Console.WriteLine("Valor final do automovel: R$" + (valorAutomovelFabrica + valorImpostoGov 
                + valorImpostoDistribuidor));


            Console.ReadKey();
        }
    }
}
