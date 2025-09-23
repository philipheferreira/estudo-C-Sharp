using _5___Polimorfismo.Entities;

namespace Treino{
    class Programa{
        static void Main(string[] args){
            Animal Generico = new Animal(4, "Semnome");
            Animal ViraLata = new Cao(4, "Frida");
            Animal GatoDeRua = new Gato(4, "Freira");

            Generico.Voz(); // Metodo original da superclasse
            ViraLata.Voz(); // Metodo da subclasse modificado
            GatoDeRua.Voz(); // Metodo da subclasse modificado
        }
    }
}