using classes;
class Programa{ 

    static void Main(string[] args){

        string nomeMain;
        int idadeMain;
        double salarioMain;

        Console.WriteLine("Qual o seu nome: ");
        nomeMain= Console.ReadLine();

        Console.WriteLine("Qual sua idade? ");
        idadeMain = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual o seu salario? ");
        salarioMain= int.Parse(Console.ReadLine());

        AutoProperties obj1 = new AutoProperties(nomeMain, idadeMain, salarioMain);

        Console.WriteLine("Ola {0}, sua idade é {1} e o seu salario é {2}", obj1.Nome, obj1.Idade, obj1.Salario);

    }
}