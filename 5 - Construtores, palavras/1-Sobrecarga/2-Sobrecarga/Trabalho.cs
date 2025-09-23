using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste{
    internal class Trabalho{

        public string Nome;
        public double Salario;
        public double Tempo;

        public Trabalho(string nome, double salario, double tempo){ // constructor feito para receber as variaveis enviadas do Program
            Nome = nome;
            Salario = salario;
            Tempo = tempo;
        }

        public Trabalho(string nome, double salario){ // Segundo constructor, realizando o fenomeno de sobrecarga. os dois tem que ter o mesmo nome
            Nome= nome;
            Salario = salario;
            Tempo = 10;
        }
        public override string ToString(){ // Esse comando é para quando eu chamar apenas o nome do objeto criado retornar algo dentro dessa função
            return Nome + ", $" + Salario + ". Tempo de trabalho: " + Tempo;
        }
    }
}
