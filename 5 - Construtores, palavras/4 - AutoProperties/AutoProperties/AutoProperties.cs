using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes{
    internal class AutoProperties{
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public double Salario { get; private set; }

        public AutoProperties(string nome, int idade, double salario){
            Nome= nome;
            Idade= idade;
            Salario= salario;
        }

    }
}
