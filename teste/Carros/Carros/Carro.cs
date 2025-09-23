using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros{
    internal class Carro{

        private string Cor;
        private string Marca;
        private string Modelo;

      /*  public Carro(string cor, string marca, string modelo){
            Cor = cor;
            Marca = marca;
            Modelo = modelo;
        } */

        public override string ToString()
        {
            return Modelo + ", " + Marca + ", " + Cor;
        }


    }
}
