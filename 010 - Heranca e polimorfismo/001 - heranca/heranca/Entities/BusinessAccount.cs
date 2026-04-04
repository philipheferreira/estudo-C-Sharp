using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace heranca.Entities{

    internal class BusinessAccount : Account{ // herança

        public double LoanLimit { get; set; } // variavel da classe filha declarada com autoproperties

        public BusinessAccount(int numero, string holder, double balanco, double loanLimit) : base(numero, holder, balanco){ // reutiliza os parametros já definidos na classe pai como base na função
            LoanLimit = loanLimit; // Declara a unica variavel que é particular na classe filha
        }

        public void Emprestimo(double valor){ // metodo declarado da classe filha
            if (valor < LoanLimit){
                Balanco= valor;
            }
        }

    }
}
