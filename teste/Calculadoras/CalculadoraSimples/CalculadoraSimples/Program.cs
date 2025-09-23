//Calculadora feita com as variaveis e metodos criadas em apenas uma classe principal

namespace CalculadoraSimples{
    class Program{
        static void Main(string[] args){


            float numero1 = 20, numero2 = 40;

            float soma, sub, mult, div;

            Console.WriteLine("O valor da primeira variavel é: " + numero1);

            Console.WriteLine("O valor da segunda variavel é: {0}", numero2 );

            
            soma = numero1 + numero2;

            sub = numero1 - numero2;

            mult = numero1 * numero2;

            div = numero1 / numero2;

            Console.WriteLine();


            Console.WriteLine($"O valor da soma das duas variaveis é {soma}.\nO valor da subtração das duas variaveis é {sub}.\nO valor da multiplicação das duas variaveis é {mult}.\nO valor da divisão das duas variaveis é {div}");
        }
    }
}
