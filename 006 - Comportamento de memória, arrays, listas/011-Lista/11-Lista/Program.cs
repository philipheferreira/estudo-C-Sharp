/*

Listas

* Lista é uma estrutura de dados:
    - Homogênea (dados do mesmo tipo)
    - Ordenada (Elementos acessados por meio de posições)
    - Inicia vazia, e seus elementos são alocados sob demanda
    - Cada elemento ocupa um "nó" (ou nodo) da lista

* Classe: List
* NameSpace: System.Collections.Generic


* Vantagens:
    - Tamanho Variável;
    - Facilidade para se realizar inserções e deleções

* Desvantagens:
    - Acesso Sequencial aos elementos


* Inserir elemento na lista: Add, Insert;
* Tamanho da lista: Count;
* Encontrar primeiro ou último elementos da lista que satisfaça um predicado: list.Find, list.FindLast;
* Encontrar primeira ou última
* Filtrar a lista com base em um predicado: list.FindAll;
* Remover elementos da lista: Remove, RemoveAll, RemoveAt, RemoveRange

*/



namespace _11_Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            List<string> list2 = new List<string> { "Maria", "Alex" };

            list.Add("Joãozinho");
            list.Add("Alessandra");
            list.Add("Fernandinha");
            list.Add("Roberto");
            list.Add("HelloKit");
            list.Add("Aluizio");
            list.Add("Anninha");
            list.Add("João");
            list.Add("Farias");
            list.Add("Ana");

            foreach (string s in list) // passa por cada elemento da list definidos como s
            {
                Console.WriteLine(s);
            }

            Console.WriteLine($"Contagem da lista: {list.Count}"); // O comando Count verifica o numero total de itens na lista


            // INICIO DA FUNÇÃO FIND

            //Função Find espera um predicado como argumento

            string primeiroNomeA = list.Find(EncontraNomeComecaA); //Tem o objetivo de encontrar o primeiro elemento da lista que satisfaça um precidado
            Console.WriteLine("Primeiro nome que começa com a Letra A da lista: " + primeiroNomeA);

            string primeiroNomeF = list.Find(x => x[0] == 'F'); //Criando as condições dentro da chamada Find;
            Console.WriteLine("Primeiro nome que começa com a Letra F da lista: " + primeiroNomeF);

            //FIM DA FUNÇÃO FIND


            //INICIO DA FUNÇÃO FINDLAST

            string ultimoNomeA = list.FindLast(EncontraNomeComecaA);

            Console.WriteLine("Ultimo nome que começa com a Letra A da lista: " + ultimoNomeA);

            string ultimoNomeF = list.FindLast(x => x[0] == 'F');

            Console.WriteLine("Ultimo nome que começa com a Letra F da lista: " + ultimoNomeF);


            //FIM DA FUNÇÃO FINDLAST

            //INICIO DA FUNÇÃO FINDINDEX

            int primeiraPosicaoNomeA = list.FindIndex(EncontraNomeComecaA); //FindIndex encotra a posição do primeiro elemento da lista que está de acordo com o predicado

            Console.WriteLine();

            int posicaoNomeF = list.FindIndex(x => x[0] == 'F');

            Console.WriteLine();

            //FIM DA FUNÇÃO FINDINDEX


            //INICIO DA FUNÇÃO FINDLASTINDEX

            int ultimaPosicaoNomeA = list.FindLastIndex(EncontraNomeComecaA);//FindLastIndex encotra a posição do último elemento da lista que está de acordo com o predicado
            Console.WriteLine();

            int ultimaPosicaoNomeF = list.FindLastIndex(x => x[0] == 'F');
            Console.WriteLine();

            //FIM DA FUNÇÃO FINDLASTINDEX

            // Filtrar uma lista é criar uma nova lista apenas com os elementos que satisfaçam o predicado

            //INICIO DO METODO FINDALL

            List<string> list3 = list.FindAll(x => x.Length <= 5);// FindAll pega todos os nomes que são menores ou iguais ao tamanho 5 e coloca em uma nova lista

            foreach (string str in list3)
            {
                Console.WriteLine(str);
            }

            //FIM DO METODO FINDALL


            //INICIO DO METODO REMOVE

            list.Remove("Farias");
            Console.WriteLine("-------------------");
            foreach (string str in list)
            {
                Console.WriteLine(str);

                //FIM DO METODO REMOVE

            }


            list.RemoveAt(0);
            Console.WriteLine("------------------");
            foreach(string str in list)
            {
                Console.WriteLine(str);
            }


            list.RemoveRange(1,2);
            Console.WriteLine("-----------------");
            foreach (string str in list)
            {
                Console.WriteLine(str);
            }



            list.RemoveAll(x => x[0] == 'A'); // RemoveAll deleta da lista todos os valores de acordo com o predicativo
            Console.WriteLine("----------------------");
            foreach (string str in list)
            {
                Console.WriteLine(str);
            }

            static bool EncontraNomeComecaA(string s)
            {
                return s[0] == 'A';
            }

        }
    }
};
