using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematica{
    class Triangulo{
        public double alturaTriangulo;
        public double baseTriangulo;
        public double lado;

        public double area() {
            return (alturaTriangulo * baseTriangulo) / 2;
         }

        public double perimetro(){
            return 3 * lado;
        }

        public double diagonal(){
            return ((alturaTriangulo * alturaTriangulo) + (lado * lado) + (lado * lado));
        }
    }
}
