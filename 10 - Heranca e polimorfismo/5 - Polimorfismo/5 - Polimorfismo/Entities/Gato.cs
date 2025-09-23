using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Polimorfismo.Entities{
    class Gato : Animal{

        public Gato(int patas, string nome) : base(patas, nome) { }

        public override void Voz(){ // Metodo modificado ocasionando o polimorfismo
            Console.WriteLine("Miauuuuu!");
        }

    }
}
