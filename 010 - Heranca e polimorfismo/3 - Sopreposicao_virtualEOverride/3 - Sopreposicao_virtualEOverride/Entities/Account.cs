using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___Sopreposicao_virtualEOverride.Entities{
    class Account{
        public int Number {  get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }
        public Account(){}

        public Account(int number, string holder, double balance){

            Number = number;
            Holder = holder;
            Balance = balance;
        
        }

        public void Saque(int value){
            Balance -= value;
        }

        public void Deposito(int value){
            Balance += value;
        }

        public virtual void Withdraw(double amount){ // utilizando o comando virtual, que tem o objetivo de criar um metodo que pode ser sobrescrevido por uma sub classe utilizando o override
            Balance -= amount + 5.0; // comandos dentro da função
        }

    }
}
