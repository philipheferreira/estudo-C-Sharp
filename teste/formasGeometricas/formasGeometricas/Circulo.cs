using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    internal class Circulo{

        private double _DiametroCirculo;

        public double GetdiametroCirculo(){ 
            return _DiametroCirculo;
        }

        public void SetDiametroCirculo(double diametroCirculo){ 
            _DiametroCirculo = diametroCirculo;
        }

        public double circuloArea(){
            return (_DiametroCirculo / 2) * (_DiametroCirculo / 2) * 3.14;
        }
    }
}
