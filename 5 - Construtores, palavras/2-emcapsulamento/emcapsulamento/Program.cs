using Trabalho;

class Programa{
    static void Main(string[] args){

        Pessoa obj1 = new Pessoa("philiphe", 2050.00);

        Console.WriteLine("Ola, {0} seu salario é de {1}R$", obj1.Nome , obj1.GetSalario()); // puxei a classe e a info da variavel foi retornada porque é a variavel que está retornando tudo

        obj1.SetSalario(3210.00);

        Console.WriteLine("Ola {0}, seu salario agora é {1}R$", obj1.Nome,obj1.GetSalario());
    }
}



