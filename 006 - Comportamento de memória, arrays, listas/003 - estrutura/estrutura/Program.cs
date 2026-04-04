/*

Structs são tipos valor: A linguagem C# possui também tipos valor, que são os 'structs'. Structs são CAIXAS e não ponteiros.

*/


using System;

namespace estrutura { 
class Programa{
    static void Main(string[] args){

            Estrutura p; // referencia a estrutura e atribuição de um nome dentro da classe que referencia estrutura
            p.x = 10;
            p.y = 20;
            Console.WriteLine(p);
            p = new Estrutura(); // criar um novo apontamento de estrutura zera tudo
            Console.WriteLine(p);
        }

    }

}