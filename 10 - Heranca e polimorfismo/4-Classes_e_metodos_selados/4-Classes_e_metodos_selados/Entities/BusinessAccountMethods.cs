using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Classes_e_metodos_selados.Entities{
    internal class BusinessAccountMethods : BusinessAccount{
        public override string ToString(){ // Não vai funcionar porque usa
            return "Não vai funcionar porque o metodo está selado";
        }
    }
}
