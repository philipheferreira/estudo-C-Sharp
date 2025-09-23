/*

Laço for each: sintaxe opcional e simplificada para percorrer coleções

Leitura: "para cada objeto 'obj' contido em vect, faça:"

string[] vect = new string[] {"Maria", "Bob", "Alex"}

foreach (){
    Console.WriteLine(obj);
}

*/


namespace _10_lacoForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Alex", "Bob" }; // vetor criado
            
            // Chamada normal usando o for
            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }
            
            // Inicio do foreach

            foreach(string obj in vect) { // obj foi o apelido criado para os valores dentro das posições preenchidas no vect
                Console.WriteLine(obj);

        }
    }
}
