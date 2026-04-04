class Program
{
    static void Main(string[] args)
    {
        bool completo = false;
        char genero = 'F';
        char letra = '\u0041';
        byte n1 = 126;
        int n2 = 1000;
        int n3 = 2147483647;
        long n4 = 2147483648L;
        float n5 = 3.14f; // sem o f nao funciona
        float n6 = 1.5e-10f; // sem o f nao funciona
        object obj1 = "Philiphe Ferreira";
        object obj2 = 12345;
        Console.WriteLine("Valor completo: " + completo);
        Console.WriteLine("Valor genero: " + genero);
        Console.WriteLine("Valor letra: " + letra);
        Console.WriteLine("Valor n1: " + n1);
        Console.WriteLine("Valor n2: " + n2);
        Console.WriteLine("Valor n3: " + n3);
        Console.WriteLine("Valor n4: " + n4);
        Console.WriteLine("Valor n5: " + n5);
        Console.WriteLine("Valor n6: " + n6);
        Console.WriteLine("Valor obj1: " + obj1);
        Console.WriteLine("Valor obj2: " + obj2);

        Console.WriteLine("Operacao de reducao e maximizacao de valores");

        int m1 = int.MinValue; // Coloca o valor minimo permitido de um numero inteiro
        int m2 = int.MaxValue; // Coloca o valor maximo permitido de um numero inteiro
        sbyte m3 = sbyte.MinValue; // Coloca o valor minimo permitido de um bite
        decimal m4 = decimal.MaxValue; // Coloca o valor maximo permitido de um numero decimal

        Console.WriteLine("Valor minimo int: " + m1);
        Console.WriteLine("Valor maximo int: " + m2);
        Console.WriteLine("Valor minimo sbyte: " + m3);
        Console.WriteLine("Valor maximo decimal: " + m4);


    }
}