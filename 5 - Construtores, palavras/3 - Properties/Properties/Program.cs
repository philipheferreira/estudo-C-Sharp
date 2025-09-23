using Properties;

class Programa{
    static void Main(string[] args){
        string nomeMain, palavraChaveMain;

        Console.WriteLine("Qual o seu nome?");
        nomeMain= Console.ReadLine();

        Console.WriteLine("Qual a palavra chave?");
        palavraChaveMain= Console.ReadLine();


        Class1 obj1 = new Class1(nomeMain, palavraChaveMain);

        Console.WriteLine("Ola {0} sua palavra chave é {1}", obj1.Nome, obj1.PalavraChave);
    }
}