using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Classes_e_metodos_selados.Entities{
    class BusinessAccount : Account{ // tecnica de herança
        public double LoanLimit { get; set; } // variavel unica dessa subclasse

        public BusinessAccount(){} // constructor
        
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance){
            LoanLimit = loanLimit;
        }

        public void Loan(double value){
            if(value > 0){
                Balance = value 
            }
        }

        public sealed override string ToString(){ // QUalquer subclasse que use essa classe como base não ira funcionar
            return "Valor do numero: " + Number + ". Valor do balanço: " + Balance + ". O valor do holder é: " + Holder;
        }
    }
}
