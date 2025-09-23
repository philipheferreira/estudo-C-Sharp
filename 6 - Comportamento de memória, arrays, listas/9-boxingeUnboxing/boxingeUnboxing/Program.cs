
/*

Boxing: É o processo de conversão de um objeto tipo valor
para um objeto tipo referência compatível

*/



/*

Unboxing:

*/


namespace boxingeUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Inicio do Boxing

            int x = 20;

            Object obj1 = x;

            // Fim do Boxing

            // Inicio do Unboxing

            int y = 40;// criando valor inteiro

            Object obj2 = y; // passando valor para objeto

            int z = (int)obj2; // passando valor inteiro para outro inteiro

            // Fim do Unboxing

        }
    }
}
