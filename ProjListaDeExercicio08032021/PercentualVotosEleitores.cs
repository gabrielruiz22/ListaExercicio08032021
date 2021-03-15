using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjListaDeExercicio08032021
{
    class PercentualVotosEleitores
    {
        static void Main(string[] args)
        {
            int qtdEleitores, votosEmBranco, votosNulos, votosValidos;
            double porcentagemEmBranco, porcentagemNulos, porcentagemValidos;

            do
            {
                Console.Write("Informe o total de eleitores de seu município: ");
                qtdEleitores = int.Parse(Console.ReadLine());
                if(qtdEleitores < 0)
                {
                    Console.WriteLine("Numero de eleitores inválidos!");
                }
            } while (qtdEleitores < 0);

            do
            {
                Console.Write("Informe o total de votos em branco: ");
                votosEmBranco = int.Parse(Console.ReadLine());
                if (votosEmBranco < 0)
                {
                    Console.WriteLine("Numero de votos em branco inválidos!");
                }
                if (votosEmBranco > qtdEleitores)
                {
                    Console.WriteLine("Votos em branco não pode ser maior que a quantidade de eleitores");
                }
            } while (votosEmBranco < 0 || votosEmBranco > qtdEleitores);

            do
            {
                Console.Write("Informe o total de votos nulos: ");
                votosNulos = int.Parse(Console.ReadLine());
                if (votosNulos < 0)
                {
                    Console.WriteLine("Numero de votos nulos inválidos!");
                }
                if (votosNulos > qtdEleitores)
                {
                    Console.WriteLine("Votos nulos não pode ser maior que a quantidade de eleitores");
                }
            } while (votosNulos < 0);

            do
            {
                Console.Write("Informe o total de votos válidos: ");
                votosValidos = int.Parse(Console.ReadLine());
                if (votosValidos < 0)
                {
                    Console.WriteLine("Numero de votos validos inválidos!");
                }
                if (votosValidos > qtdEleitores)
                {
                    Console.WriteLine("Votos validos não pode ser maior que a quantidade de eleitores");
                }
            } while (votosValidos < 0);

            porcentagemEmBranco = votosEmBranco * 100 / qtdEleitores;
            porcentagemNulos = votosNulos * 100 / qtdEleitores;
            porcentagemValidos = votosValidos * 100 / qtdEleitores;

            Console.WriteLine("Porcentagem votos em branco: " + porcentagemEmBranco);
            Console.WriteLine("Porcentagem votos nulos: " + porcentagemNulos);
            Console.WriteLine("Porcentagem votos validos: " + porcentagemValidos);
           
            Console.ReadKey();

        }
    }
}
