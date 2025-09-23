using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaReTreino.Entities{
    internal class Trabalhador : Pessoa{
        public double HorarioDeTrabalho { get; set; }

        public Trabalhador() { }

        public Trabalhador(string nome, int idade, double totalDePassos, double horarioDeTrabalho) : base(nome, idade, totalDePassos){ // comando base consegue usar o constructor já declarado na super classe assim coomo suas variaveis
            HorarioDeTrabalho = horarioDeTrabalho;
        }

        public void Salto(double duploPasso){ 
            TotalDePassos = TotalDePassos + (duploPasso * 2);
        }

        public override string ToString()
        { // Esse comando é para quando eu chamar apenas o nome do objeto criado retornar algo dentro dessa função
            return "O nome do trabalhor é:" + Nome + ", Idade: " + Idade + ". Total de passos: " + TotalDePassos + ". ";
        }
    }
}
