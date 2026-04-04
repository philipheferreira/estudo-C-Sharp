using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_UpcastingDowncasting.Entities{
    class Account{
        public int Number {  get; private set; }
        public string Holder {  get; private set; }
        public double Balance { get; protected set; }

        public Account(){ }

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
        public override string ToString(){
            return Holder + " , $" + Balance + ". Numero:  " + Number;
        }
    }
}
