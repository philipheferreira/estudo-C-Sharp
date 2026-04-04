/* polimorfismo significa muitas formas, e ocorre quando nos temos muitas classes que herdam de uma classe principal.
Polimorfismo usa os metodos para realizar performaces de diferentes tarefas. Isso permite performar uma simples 
ações de diferentes maneiras
*/

class Animal{ //classe base (pai)

    public virtual void somAnimal(){ // torna o metodo possivel para ser sobreescrito por outro metodo de uma classe filha
        Console.WriteLine("O animal faz um som");
    }

}

class Porco : Animal{ // Classes que funcionam como filhas
    public override void somAnimal(){ // O comando override sobrepoem um metodo com o mesmo nome que seja importada da classe pai
        Console.WriteLine("O porco diz: Wee wee");
    }
}

class Cachorro : Animal{ // O comando override sobrepoem um metodo com o mesmo nome que seja importada da classe pai
    public override void somAnimal() { Console.WriteLine("O cachorro diz: au au");
    }
}

class Programa{
    static void Main(string[] args){ 
        Animal meuAnimal = new Animal(); // a base para criação desse objeto é tanto o pai quanto o filho. Caso ocorra alguma modificação na classe filha o mesmo metodo na classe pai é mandado de forma geral
        Animal meuPorco = new Porco(); // usando polimorfismo criando o Animal como base(pai)
        Animal meuCachorro = new Cachorro(); // usando polimorfismo criando o Animal como base(pai)

        meuAnimal.somAnimal();
        meuPorco.somAnimal();
        meuCachorro.somAnimal();
    }
}