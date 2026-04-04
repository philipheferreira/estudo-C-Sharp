using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Classes_Abstratas.Entities{
    abstract class Account{
        public int Numero {  get; set; }
        public string Holder {  get; set; }
        public double Balance {  get; set; }

        public Account() { }

        public Account(int numero, string holder, double balance){
            Numero = numero;
            Holder = holder;
            Balance = balance;
        }

        public void Saque(double valor){
            Balance -= valor;
        }

        public void Deposito(double valor){
            Balance += valor;
        }

        public virtual void Withdraw(double amount){
            Balance -= amount + 5.0;
        }

        public override string ToString(){
            return "Holder: " + Holder + ",  Balance: " + Balance +", Numero: " + Numero ;
        }
    }
}
