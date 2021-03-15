using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjListaDeExercicio08032021
{
    class SalarioFuncionarioComissao2
    {
        static void Main(string[] args)
        {
            double salarioFixo, valorTotalDeVendas, valorTotalSalario = 0;
            
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
                Console.Write("Informe o valor total de vendas: ");
                valorTotalDeVendas = double.Parse(Console.ReadLine());

                if (valorTotalDeVendas < 0)
                {
                    Console.WriteLine("Valor invalido");
                }

            } while (valorTotalDeVendas < 0);

            if(valorTotalDeVendas <= 1500)
            {
                valorTotalSalario = salarioFixo + (valorTotalDeVendas * 3) / 100;
            }
            if (valorTotalDeVendas > 1500)
            {
                double aux = valorTotalDeVendas - 1500;
                valorTotalSalario = salarioFixo + (1500 * 3) / 100;
                valorTotalSalario = valorTotalSalario + (aux * 5) / 100;
            }
            
            Console.WriteLine("Salario total: R$" + valorTotalSalario);
            
            Console.ReadKey();
        }
    }
}
