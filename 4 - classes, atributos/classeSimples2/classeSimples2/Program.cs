class teste{

    class Carro{
        public string cor = "vermelho";
        public int velocidadeMaxima = 200;
        public int ano = 9999;

        public void somCarro(){
            Console.WriteLine("vraummmmmmm");
        }

    }

    static void Main(String[] args){


        Carro Opala = new Carro();
        Opala.cor = "Azul";
        Opala.velocidadeMaxima = 240;
        Opala.ano = 1969;

        Console.WriteLine("A cor do seu carro opala é " + Opala.cor + ", ele faz velocidade maxima de " + Opala.velocidadeMaxima + "km/s e é de " + Opala.ano);

        Opala.somCarro();

        Carro Ferrari = new Carro();
        Ferrari.cor = "Preto";
        Ferrari.velocidadeMaxima = 320;
        Ferrari.ano = 1989;

        Console.WriteLine("A cor do seu carro Ferrari é " + Ferrari.cor + ", ele faz velocidade maxima de " + Ferrari.velocidadeMaxima + "km/s e é de " + Ferrari.ano);
        Ferrari.somCarro();
    }
}