using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaReTreino.Entities{
    internal class Pessoa{
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public double TotalDePassos { get; protected set; } // O protected permite que as subclasses tenham acesso a super classe para modifica essa variavel em especifico

        public Pessoa(){} // Construtor

        public Pessoa(string nome, int idade, double totalDePassos){
            Nome = nome;
            Idade = idade;
            TotalDePassos = totalDePassos;
        }

        public void RegredirPassos(double menosPassos){
            TotalDePassos -= menosPassos;
        }

        public void ProsseguirPassos(double maisPassos){
            TotalDePassos += maisPassos;
        }
    }
}
