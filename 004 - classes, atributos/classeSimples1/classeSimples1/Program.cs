using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Carro{
   public string cor = "vermelho"; /* quando a o main está dentro da classe que está sendo chamada 
não a necessidade de usar o public. ele só é usado para chamar um atributo ou metodo de outra classe em um outro arquivo*/
    static void Main(string[] args){
        Carro objeto = new Carro(); // criando um objeto
        Carro objeto2 = new Carro(); // criando um segundo objeto com a mesma classe
        Console.WriteLine(objeto.cor); // pegando as informações desse objeto
        Console.WriteLine(objeto2.cor); // o objeto tem as mesmas informações da classe que o primeiro objeto foi criada

    }

}



