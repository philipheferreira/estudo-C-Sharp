using System.Globalization;
using matematica;

    class Programa{
    static void Main(string[] args){

        Triangulo obj1= new Triangulo();

        Console.WriteLine("Digite a altura do triangulo: ");
        obj1.alturaTriangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite a base do triangulo: ");
        obj1.baseTriangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o lado do triangulo: ");
        obj1.lado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double area = obj1.area();

        Console.WriteLine("A area da base e altura é: {0}", area);

        double perimetro = obj1.perimetro();

        Console.WriteLine("O perimetro do triangulo é: {0}", perimetro);

        double diagonal = obj1.diagonal();

        Console.WriteLine("A Diagonal do triangulo é: {0}", diagonal);
    }
}