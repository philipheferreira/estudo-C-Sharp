class Veiculo{ // classe pai

    public string montadora = "Ford"; // variavel criada na classe pai

    public void buzina(){ // metodo criado na classe pai
        Console.WriteLine("Biii, biii!");
    }

}


class Carro : Veiculo{ // classe filha que pega todas as propriedades da classe pai
    public string modeloNome = "Mustang"; // variavel criada na classe filho 
} 

class Programa{ 

    static void Main(string[] args){ 
    
        Carro meuCarro = new Carro(); // pega a classe carro e cria um objeto meuCarro com as caracteristicas do pai (veiculo) e filho (carro)

        meuCarro.buzina(); // metodo da classe pai (Veiculo) que foi passada para classe filho (carro) e está sendo chamada pelo objeto (meuCarro) criada com base na classe filho

        Console.WriteLine(meuCarro.montadora + " " + meuCarro.modeloNome);

    }

}