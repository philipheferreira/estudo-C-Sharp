using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___Sopreposicao_virtualEOverride.Entities{
    class BusinessAccount : Account{

        public double LoanLimit { get; set; }
        public BusinessAccount(){}

        public BusinessAccount(int number, string holder, double balance, double loanLimit): base(number, holder, balance){
            LoanLimit = loanLimit;
        }

        public void Loan(double value){
            if (value < LoanLimit){
                Balance = value;
            }
        }

        public override void Withdraw(double amount){
            base.Withdraw(amount); // usando base a implementação dentro da superclasse com o virtual é chamada, realizando a operação dentro da superclasse
            Balance -= 2.0; // após descontar os 5 reais dentro da super classe com a chamada da base, é discontado esses 2 reais desse comando dentro da função da subclasse
        }

    }
}
