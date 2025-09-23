/*
Classes são tipos referência: Variáveis cujo tipo são classes não devem ser entendidas como caixas, mas sim "tentáculos" (ponteiros) para caixas.

VALORES PADRÃO
 - Quando alocamos (NEW) qualquer tipo estruturado (classe, struct, array), são atribuídos valores padrão aos seus elementos


- Lembrando: Uma variável apenas declarada, mas não instanciada, inicia em estado "não atribuída", 
e o próprio compilador não permite que ela seja acessada.

*/
namespace ClasseExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Classe p1 = new Classe("TV", 900.00, 0); // Inicializa a classe com um objeto

            object p2; // define um p2 criando um objeto

            p2 = p1; // faz um apontamento de p1 para p2, fazendo o p2 receber tudo

            Console.WriteLine(p2);
        }
    }
}
