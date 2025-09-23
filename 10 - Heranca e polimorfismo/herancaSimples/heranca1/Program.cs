using heranca1;

class Program{
    static void Main(string[] args){
        Animal myAnimal = new Animal();  // Create a Animal object
        Animal myPig = new Porco();  // Create a Pig object
        Animal myDog = new Cachorro();  // Create a Dog object

        myAnimal.somdeAnimal();
        myPig.somdeAnimal();
        myDog.somdeAnimal();
    }
}