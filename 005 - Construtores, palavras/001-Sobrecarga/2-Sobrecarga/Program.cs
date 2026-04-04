using System.Globalization;
using teste;

    class Programa{
        
        static void Main(string[] args){

        string nome;
        double salario, tempo;

        Console.WriteLine("Digite o nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("Digite o salario do trabalhador: ");
        salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o tempo de trabalho: ");
        tempo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Trabalho obj1 = new Trabalho(nome, salario, tempo);

        Trabalho obj2 = new Trabalho(nome, salario);

        Trabalho obj3 = new Trabalho(nome = "Joãozinho", salario = 3200 , tempo = 2); // Já inicializa com o construtor colocando valores definidos dentro do objeto


        Console.WriteLine("Infos gerais do obj1: {0}", obj1);

        Console.WriteLine("Infos gerais do obj2: {0}", obj2);

        Console.WriteLine("Infos gerais do obj3: {0}", obj3);

    }

}