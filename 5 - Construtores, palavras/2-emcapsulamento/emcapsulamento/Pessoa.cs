using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho{
    internal class Pessoa{
        public string Nome; // nome é uma variavel publica então ainda pode ser puxado de forma direta por outra classe sem gerar problema
        private double _Salario; // variavel salario criada sendo privada, então não se pode mais puxar ela direto
        public Pessoa(string nome, double salario) {
            Nome = nome;
            _Salario = salario;
        }

        public double GetSalario() { // é necessario criar uma função dentro da classe que tem a variavel privada para poder utilizala
            return _Salario;
        } 

        public void SetSalario(double salario){
            if (salario != null && salario > 2000) { 
            _Salario = salario;
            }
        }

    }
}
