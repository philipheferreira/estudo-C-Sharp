using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Classes_e_metodos_selados.Entities{
    class Account{
        public int Number {  get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

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
    }
}
