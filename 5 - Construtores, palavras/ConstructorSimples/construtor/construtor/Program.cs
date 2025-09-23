class Treino{ 

    class Carro{
        public string Modelo;
        public string Cor;
        public int Ano;

        public Carro(string modelo, string cor, int ano){
            Modelo = modelo;
            Cor = cor;
            Ano = ano;
        }
    }

    static void Main(string[] args){
        
        Carro Ford = new Carro("Mustang", "vermelho", 1977);

        Console.WriteLine("O modelo do seu carro é: {0}, da cor {1} e do ano de {2}" ,Ford.Modelo, Ford.Cor, Ford.Ano);

    }
}