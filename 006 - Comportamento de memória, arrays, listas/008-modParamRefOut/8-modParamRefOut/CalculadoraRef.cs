
/*

Modificador Ref: Suponha que se queira uma calculadora com uma operação para triplicar o valor de um número passado parâmetro.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_modParamRefOut
{
    internal class CalculadoraRef
    {

        public static void Triple(ref int x)
        {
            x = x * 3;
        }

    }
}
