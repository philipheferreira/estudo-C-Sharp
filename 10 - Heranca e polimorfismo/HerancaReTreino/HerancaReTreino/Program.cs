
using HerancaReTreino.Entities;
namespace Treino{
    class Programa{
        static void Main(string[] args){
            Trabalhador empregado = new Trabalhador("Philiphe Siqueira Ferreira", 24, 200, 19.00);

            empregado.Salto(10); // Realizou o metodo saldo dentro da subclasse Trabalhador

            Console.WriteLine(empregado);
        }
    }
}