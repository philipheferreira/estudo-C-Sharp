using HerancaTeste.Entities;

namespace Treino{ 
    class Programa { 
        static void Main(string[] args){
            SubClasse individuo = new SubClasse("Philiphe Siqueira Ferreira", 22, "Desenvolvedor Front e Backend", 191);

            Console.WriteLine(individuo);

            individuo.Nome = "Lorran Livian";
            individuo.Idade = 28;
            individuo.Trabalho = "Gerente de Projeto";
            individuo.Id = 111;

            Console.WriteLine("\nNovo nome: " + individuo.Nome);
            Console.WriteLine("Nova Idade: " + individuo.Idade);
            Console.WriteLine("Novo Trabalho: " + individuo.Trabalho);
            Console.WriteLine("Novo Id: " + individuo.Id);

        }
    }

}