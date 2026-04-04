/*

Problema Exemplo 2: Fazer um programa para ler um número inteiro N e os dados (nome e preço) de N Produtos.
Armazene os N produtos em um vetor. Em seguida, mostrar o preço médio dos produtos.

*/

using Vetor;
using System.Globalization;

namespace _6___Vetor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            Produto[] vetor = new Produto[n];

            for (int i = 0; i < n; i++)
            {

                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
                vetor[i] = new Produto { Nome = nome, Preco = preco }; // sintaxe de estanciação sem os construtores
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vetor[i].Preco;
            }

            double avg = soma / n;
            Console.WriteLine("Media de Preço = " + avg.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
