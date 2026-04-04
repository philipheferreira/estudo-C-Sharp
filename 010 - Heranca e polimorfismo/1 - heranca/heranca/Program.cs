using System;
using heranca.Entities;

namespace Treino{
    class Programa{ 
        static void Main(string[] args){ 
            BusinessAccount account = new BusinessAccount(2020, "Philiphe", 100.0, 500.0);

            Console.WriteLine(account);

            account.Balanco = 400.0;

            Console.WriteLine("o valor atual do balanço na conta é: {0}", account.Balanco);
        }
    }
}