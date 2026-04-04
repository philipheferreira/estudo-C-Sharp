class Programa{

    enum Level{ // o enum é um,a classe especial para representar o gripo de constantes;
        Low,
        Medium, 
        High

        }

    enum meses{

        Janeiro, // 0
        Fevereiro, // 1
        Março, // 2
        Abril, // 3
        Maio, //4
        Junho, // 5
        Julho // 6

    }

    enum teste{ 
        teste1 = 1,
        teste2,
        teste3,
        teste4,
        teste5,
        teste6

    }

    static void Main(string[] args){

        Level minhaVariavel = Level.Low;
        Console.WriteLine(minhaVariavel);

        int mesVariavel = (int)meses.Abril;
        Console.WriteLine(mesVariavel);

        int enumVariTeste = (int)teste.teste5;
        Console.WriteLine(enumVariTeste);

        Level escolha = Level.Medium;
        switch (escolha){

            case Level.Low: 
                Console.WriteLine("escolha de nivel baixo");
                break;
            case Level.Medium:
                Console.WriteLine("escolha de nivel medio");
                break;
            case Level.High:
                Console.WriteLine("escolha de nivel alto");
                break;
        }


    }

}