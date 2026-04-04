using _6_Classes_Abstratas.Entities;
using System.Collections.Generic;
using System.Globalization; // serve para poder utilizar como lista


namespace Treino{
    class Programa{
        static void Main(string[] args){
            List<Account> list = new List<Account>(); // usar o account que é uma classe abstrata como uma lista
            list.Add(new SavingsAccount(1001, "João", 500.00, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.00, 400.00));
            list.Add(new SavingsAccount(1003, "Karla", 500.00, 0.02));
            list.Add(new BusinessAccount(1004, "Pedro", 500.00, 300.00));

            double sun = 0.0; // criado uma variavel vazia para receber a soma de todos os valores balance somados das contas criadas dentro da lista
            foreach (Account acc in list){ // criado um comando for em que cria variaveis acc na lista 
                sun += acc.Balance; // todas as contas são conhecidas como objetos acc e as caracteristicas balance de cada um são somadas dentro de sun
            }

            Console.WriteLine("Total balance: " + sun.ToString("F2", CultureInfo.InvariantCulture));
        }          
    }
}