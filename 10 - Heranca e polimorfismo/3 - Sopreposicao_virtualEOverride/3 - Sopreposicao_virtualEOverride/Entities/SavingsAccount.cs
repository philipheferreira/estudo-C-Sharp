using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___Sopreposicao_virtualEOverride.Entities{
    internal class SavingsAccount : Account{
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance){ 
            InterestRate = interestRate;
        }

        public void UpdateBalance(){
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount){ // override substitui os comandos dentro da função da superclasse
            Balance -= amount;  
        }
    }
}
