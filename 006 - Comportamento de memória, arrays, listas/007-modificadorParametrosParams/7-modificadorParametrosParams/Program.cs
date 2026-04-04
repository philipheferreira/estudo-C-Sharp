using System;

namespace _7_modificadorParametrosParams
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int s1 = Calculadora.Sum( new int[] { 2, 3 }); // forma de chamar variaveis para o vetor sem o params
            int s2 = Calculadora.Sum(2, 4, 3, 5, 7, 8); // chamada com a adição do params 

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
