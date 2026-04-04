using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaTeste.Entities{
    internal class SubClasse : SuperClasse{
        public int Id {  get; set; }

        public SubClasse(string nome, int idade, string trabalho, int id) : base(nome, idade, trabalho){
            Id = id;
        }

        public override string ToString(){
            return "O nome do individuo "+ Nome +".\nA idade é " + Idade + ".\nO trabalho é "+ Trabalho + ".\nO identificador é:" + Id; 
        }
    }
}
