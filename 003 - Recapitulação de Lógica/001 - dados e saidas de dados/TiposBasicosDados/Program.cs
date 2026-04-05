using System;
using System.Globalization;

/* Neste primeiro codigo estou fazendo o teste de cada declaração de variavel. Também estou exercitando o tipo de chamada. Sendo que existem 3.
 * A primeira é referente a como era no C. Sendo que posso definir quais das variaveis quero puxar. 
   A segunda é a de concatenação, comum na aplicação de Javascript
   A terceira é a chamada mais direta e a mais utilizada*/

namespace PrimeiroProjeto{
    class Programa{
        static void Main(string[] args){
            bool teste = true;
            byte n1 = 1;
            int idade = 27;
            double saldo = 2000;
            double saldoVirgula = 20.231245;
            string nome = "Philiphe";
            char genero = 'M';

            Console.WriteLine("Ola, {0} como está seu dia? Seu genero é {1}", nome, genero); // Primeira forma de declarar comunicação output
            Console.WriteLine( "Você tem " + idade + " anos"); // segunda forma de declarar comunicação output
            Console.WriteLine($"seu byte tem o valor de {n1} e seu saldo é de {saldo}"); // Terceira forma de declarar comunicação output
            Console.WriteLine(saldoVirgula.ToString("F2")); // O Tostring cria um limitador para casas depois da virgula mostrada
            Console.WriteLine(saldoVirgula.ToString("F4"));
            Console.WriteLine(saldoVirgula.ToString("F4"), CultureInfo.InvariantCulture);

            int idade2 = 32;
            double saldo2 = 10.123541;
            string nome2 = "Maria";

            Console.WriteLine("Ola,{0} tem {1} com o saldo de {2} reais", nome2, saldo2, idade2);

            Console.WriteLine("Ola,{0} tem {1:F4} com o saldo de {2:F2} reais", nome2, saldo2, idade2);

            Console.WriteLine($"{nome2} tem {idade2} anos e tem saldo igual a {saldo:F4} reais");

            Console.WriteLine("Ola," + nome2 + "tem " + idade2 + "e tem " + saldo.ToString("F4") + " Reais");

            Console.WriteLine("Ola," + nome2 + "tem " + idade2 + "e tem " + saldo.ToString("F4", CultureInfo.InvariantCulture) + " Reais");
        }
    }
}


