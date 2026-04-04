using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Classes_Abstratas.Entities{
    class SavingsAccount : Account{
        public double InterestRate {  get; set; }
        public SavingsAccount(){ }
        public SavingsAccount(int numero, string holder, double balance, double interestRate) : base(numero, holder, balance){
            InterestRate = interestRate;
        }

        public void UpdateBalance(){
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount){
            Balance -= amount;
        }
    }
}
