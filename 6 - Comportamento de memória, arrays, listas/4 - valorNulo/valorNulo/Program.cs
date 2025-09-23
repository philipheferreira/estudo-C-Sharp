/*

MULLABLE:
 - É um recurso de C# para que dados de tipo valor (structs) possam receber o valor null

 * Uso comum:
   - Campos de banco de dados que podem valer nulo ( data de nascimento, algum valor numérico, etc. ).
   - Dados e parâmetros opcionais

*/

using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Nullable<double> x = null; //Significa que posso receber valores nulos
            double? y = 10.0; // Outra forma de dizer que posso receber um valor nulo

            Console.WriteLine(x.GetValueOrDefault()); // esse comando é pra pegar o valor dentro da variavel e se não existir pegar o valor padrão dentro da variavel
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue); //Faz um repasse da informação se x tem valor ou não. Se não tiver retorna false
            Console.WriteLine(y.HasValue); // Tem valor então é retornado True


            // esta comentado mas a baixo está explicado
            //Console.WriteLine(x.Value); // Pega a informação diretamente da variavel. caso não tenha vai quebrar a aplicação
            //Console.WriteLine(y.Value); // esse vai funcionar porque tem um valor

            //Como o caso de se eu pegar o Value direto quebrara então irei fazer um condicional para especificar as informações

            if(x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X é nulo");

            if(y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y é Nulo");

            double a = x ?? 5; // Operador de coalecencia nulo: caso o valor de x seja nulo, então ele não ira repassar para a o valor de x, mas o valor a direita, que é 5. Caso tenha um valor em x, então ele ira colocar o valor de x em a.
            double b = y ?? 5; // Operador de coalecencia nulo: caso o valor de y seja nulo, então ele não ira repassar para b o valor de y, mas o valor a direita, que é 5. Caso tenha um valor em y, então ele ira colocar o valor de y em b.
        
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}