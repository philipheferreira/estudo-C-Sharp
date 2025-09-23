using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    internal class Retangulo{

        private double _RetanguloValor1;
        private double _RetanguloValor2;

        public double GetRetanguloValor1(){
            return _RetanguloValor1;
        }

        public double GetRetanguloValor2(){ 
            return _RetanguloValor2;
        }
        
        public void SetRetanguloValor1(double retanguloValor1){ 
            _RetanguloValor1 = retanguloValor1;
        }

        public void SetRetanguloValor2(double retanguloValor2){ 
            _RetanguloValor2 = retanguloValor2;
        }

        public double retanguloArea(){
            return _RetanguloValor1 * _RetanguloValor2;
        }

    }
}
