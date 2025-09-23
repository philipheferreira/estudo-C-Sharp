

using _3___Sopreposicao_virtualEOverride.Entities;

namespace Treino{ 
    class Programa{ 
        static void Main(string[] args){

            Account acc1 = new Account(1001, "João", 500.0); // cria um objeto com base da superclasse
            Account acc2 = new SavingsAccount(1002, "Ronaldo", 500.0, 0.01); // cria um objeto com base da subclasse
            Account acc3 = new BusinessAccount(1003, "Philiphe", 500.0, 0.01); // cria um objeto com base da subclasse

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);
            acc3.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            Console.WriteLine(acc3.Balance);

        }
    }
}