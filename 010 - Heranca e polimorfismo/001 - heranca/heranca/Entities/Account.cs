using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca.Entities{
    internal class Account{
        public int Numero { get; set; } // cria os metodos de enviar e pegar o valor da variavel
        public string Holder { get; set; } // cria os metodos de enviar e pegar o valor da variavel
        public double Balanco { get; set; } // cria os metodos de enviar e pegar o valor da variavel

        public Account(){ // construtor
        
        }

        public Account(int numero, string holder, double balanco) { // sobrecarga
            Numero= numero;
            Holder= holder;
            Balanco= balanco;
        }

        public void Saque(double valor){ // metodo
            Balanco -= valor;
        }
        public void Deposito(double valor){ // metodo
            Balanco += valor;
        }
        public override string ToString(){
            return Holder + ", $" + Balanco + ". Numero: " + Numero;
        }
    }
}
