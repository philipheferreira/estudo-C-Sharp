abstract class Animal{ /* Uma Classe abstrata tem a possibilidade de esconder detalhes e mostrar apenas as informações 
                        * essencias ao usuario. A abstração pode ser usada em classes abstratas ou interfaces.
                        * -Abstract class: É uma classe restrita e não pode ser usada pra criar objetos (para acessar é 
                        * necessario usar herança de outra classe).
                        * metodo abstrato: usado apenas em classes abstratas, e não possui um corpo. O corpo é providenciado
                        * na classe derivada(da herança) */
    public abstract void somAnimal();
    public void sleep(){
        Console.WriteLine("....Zzzzzzz......");
    }
}

class Porco : Animal{
    public override void somAnimal(){ // usando o override para criar o corpo do metodo abstrato criado na classe abstrata
        Console.WriteLine("hoink hoink"); 
    }
}

class Programa{
    static void Main(string[] args){ 
        //Animal Ovelha = new Animal(); // Uma classe abstrata não pode ter um objeto criado diretamente. Se não ocorre erro
        Porco meuPorco = new Porco();
        meuPorco.somAnimal();
        meuPorco.sleep();
    }
}