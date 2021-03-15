using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjListaDeExercicio08032021
{
    class SalarioFuncionarioComissao
    {
        static void Main(string[] args)
        {
            int porcentagemDoValorTotalVendido = 5, quantidadeDeCarrosVendidos;
            double salarioFixo, valorDaPorcentagemDoTotal, totalValorPorCarro, valorTotalDeVendas, valorPorCarroVendido;

            do
            {
                Console.Write("Informe o salario fixo: ");
                salarioFixo = double.Parse(Console.ReadLine());

                if (salarioFixo < 0)
                {
                    Console.WriteLine("Valor invalido");
                }

            } while (salarioFixo < 0);

            do
            {
                Console.Write("Informe a quantidade de carros vendidos: ");
                quantidadeDeCarrosVendidos = int.Parse(Console.ReadLine());

                if (quantidadeDeCarrosVendidos < 0)
                {
                    Console.WriteLine("Valor invalido");
                }

            } while (quantidadeDeCarrosVendidos < 0);

            do
            {
                Console.Write("Informe o valor total de vendas: ");
                valorTotalDeVendas = double.Parse(Console.ReadLine());

                if (valorTotalDeVendas < 0)
                {
                    Console.WriteLine("Valor invalido");
                }

            } while (valorTotalDeVendas < 0);

            do
            {
                Console.Write("Informe o valor recebido por carro vendido: ");
                valorPorCarroVendido = double.Parse(Console.ReadLine());

                if (valorPorCarroVendido < 0)
                {
                    Console.WriteLine("Valor invalido");
                }

            } while (valorPorCarroVendido < 0);

            valorDaPorcentagemDoTotal = (valorTotalDeVendas * porcentagemDoValorTotalVendido) / 100;
            totalValorPorCarro = valorPorCarroVendido * quantidadeDeCarrosVendidos;

            Console.WriteLine("Total valor do salário: R$" + (salarioFixo + valorDaPorcentagemDoTotal + totalValorPorCarro));
            Console.ReadKey();
        }
    }
}
