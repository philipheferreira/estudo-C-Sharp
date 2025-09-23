using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Polimorfismo.Entities{
    class Cao : Animal{


        public Cao(int patas, string nome) : base(patas,nome){
        
        }
        public override void Voz(){ // metodo modificado na subclasse ocasionando o polimorfismo
            Console.WriteLine("AUAU"); 
        }
    }
}
