
/*

    Modificador Out: O modificador out é similar ao ref(faz o parâmetro ser 
    uma referência para a variável original), mas não exige que a variável original 
    seja iniciada.

*/

namespace _8_modParamRefOut
{
    internal class CalculadoraOut
    {

        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }

    }
}
