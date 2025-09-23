

using Classe;
using System.ComponentModel.Design;

class Programa{

    static void Main(string[] args){
        Quadrado obj1 = new Quadrado();
        Retangulo obj2 = new Retangulo();
        Circulo obj3 = new Circulo();

        int menu;


        do{

            Console.WriteLine("Escolha o que deseja fazer.\n1-calcular quadrado.\n2-calcular retangulo.\n3- calcular circulo\n0-Sair");
            menu = Convert.ToInt32(Console.ReadLine());

    

            switch (menu){

                case 1:

                    double numeroQuadrado;

                    Console.WriteLine("Digite o lado do quadrado:");
                    numeroQuadrado = double.Parse(Console.ReadLine());

                    obj1.setQuadradoValor1(numeroQuadrado);

                    Console.WriteLine("{0}", obj1.quadradoArea());

                break;

                case 2:

                    double numeroRetangulo1, numeroRetangulo2;

                    Console.WriteLine("Digite a primeira lateral do retangulo: ");
                    numeroRetangulo1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a segunda lateral do retangulo: ");
                    numeroRetangulo2 = double.Parse(Console.ReadLine());

                    obj2.SetRetanguloValor1(numeroRetangulo1);
                    obj2.SetRetanguloValor2(numeroRetangulo2);

                    Console.WriteLine("" + obj2.retanguloArea());

                break;

                case 3:

                    double numeroDiametro;

                    Console.WriteLine("Digite o diametro do circulo");
                    numeroDiametro = double.Parse(Console.ReadLine());

                    obj3.SetDiametroCirculo(numeroDiametro);

                    Console.WriteLine("" + obj3.circuloArea());

                break;


            }

        }while(menu != 0);

    }
}