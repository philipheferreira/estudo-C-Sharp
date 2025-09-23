using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Classes_e_metodos_selados.Entities{
    sealed class SavingsAccount : Account{ // O comando sealed na frente significa que não se pode criar de nenhuma forma subclasses com a SavingsAccount como base, caso seja feito retornara erro
        public double InterestRate{ get; set; }

        public SavingsAccount(){}

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number,holder,balance){
            InterestRate = interestRate;
        }

        public void UpdateBalance(){
            Balance += Balance * InterestRate;
        }

    }
}
