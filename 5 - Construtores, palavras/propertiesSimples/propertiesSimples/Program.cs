class Pessoa{ // criação de uma classe com base de properties
    private string nome; // Campo
    public string Nome{ // Propriedade
        get { return nome;} // get metodo
        set { nome = value; } // set metodo
    }

}

class Animal{

    public string Nome { get; set; }

}

class Programa{ 
    static void Main(string[] args){ 
        Pessoa objeto = new Pessoa(); //criação de um objeto com base em uma pessoa
        objeto.Nome = "Romulo"; // Uso do metodo set
        Console.WriteLine(objeto.Nome); // Uso do metodo get


        Animal cachorro = new Animal();
        cachorro.Nome = "Frida";
        Console.WriteLine (cachorro.Nome);

    }
}