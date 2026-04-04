using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Classes_Abstratas.Entities{
    class BusinessAccount : Account{

        public double LoanLimit { get; set; }

        public BusinessAccount() { }

        public BusinessAccount(int numero, string holder, double  balance, double loanLimit) : base (numero, holder, balance){
            LoanLimit = loanLimit;
        }
        public void Loan(double value){
            if (value < LoanLimit){
                Balance = value;
            }
        }

        public override void Withdraw(double amount){
            base.Withdraw(amount);
            Balance -= 2.0;
        }

    }
}
