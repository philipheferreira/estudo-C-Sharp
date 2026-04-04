using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Polimorfismo.Entities{
    class Animal{

        public int Patas { get; set; }
        public string Nome { get; set; }

        public Animal(int patas, string nome){
            Patas = patas;
            Nome = nome;
        }

        public virtual void Voz(){ // metodo original dos animais que ira sofrer mudança, ocasionando o polimorfismo
            Console.WriteLine("Sommmmmm!");
        }

    }
}
