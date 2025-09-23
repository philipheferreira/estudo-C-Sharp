using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe{
    internal class Quadrado{

        public double _QuadradoValor1;

        public double getQuadradoValor1(){
            return _QuadradoValor1;
        }

        public void setQuadradoValor1(double quadradoValor1){
            _QuadradoValor1 = quadradoValor1;
        }

        public double quadradoArea(){
            return _QuadradoValor1 * _QuadradoValor1;
        }



    }
}
