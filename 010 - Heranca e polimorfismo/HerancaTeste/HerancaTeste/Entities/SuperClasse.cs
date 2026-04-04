using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaTeste.Entities{
    internal class SuperClasse{

        public string Nome {  get; set; }
        public int Idade {  get; set; }
        public string Trabalho { get; set; }

        public SuperClasse(){ // constructor

        }

        public SuperClasse(string nome, int idade, string trabalho){
        
            Nome = nome;
            Idade = idade;
            Trabalho = trabalho;

        }


    }
}
