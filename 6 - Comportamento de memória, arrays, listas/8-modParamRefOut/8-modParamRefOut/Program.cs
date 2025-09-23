
namespace _8_modParamRefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // inicio da operação com o Ref
            int a = 10;
            CalculadoraRef.Triple(ref a);
            Console.WriteLine(a);
            // fim da operação com o ref

            // Inicio da operação com Out
            int b = 20;
            int triple;
            CalculadoraOut.Triple(a, out triple);
            Console.WriteLine(triple);
            // Fim da operação com Out

        }
    }
}
