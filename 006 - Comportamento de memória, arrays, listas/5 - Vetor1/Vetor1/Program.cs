/*

    * Em programação, "vetor" é o nome dado a arranjos unidimensionais
    * Arranjo é uma estrutura de dados:
        - Homogênea (dados do mesmo tipo);
        - Ordenada (Elementos acessados por meio de posições)
        - Alocada de uma vez só, em um bloco contíguo de memória
    
    * Vantagens:
        - Acesso imediato aos elementos pela sua posição;
    * Desvantagens:
        - Tamanho fixo;
        - Dificuldade para se realizar inserções e deleções

*/


using System;
using System.Globalization;

namespace Treino{
    class Programa{
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine()); // Tamanho do vetor

            double[] vetor = new double[n];

            for (int i = 0; i< n; i++) // percorre todo o vetor
            {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // define o valor armazenado em cada posição do vetor
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) // percorre todo o vetor
            {
                sum += vetor[i]; // vai recebendo e somando cada valor do vetor dentro da variavel
            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));

        }


    }
}