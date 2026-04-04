using System.Globalization;
using semestre;

class programa{
        
        static void Main(string[] args){
        Aluno obj1 = new Aluno();
            
            Console.WriteLine("Digite o valor da primeira nota: ");
            obj1.nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da segunda nota: ");
            obj1.nota2= double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o valor da terceira nota: ");
            obj1.nota3= double.Parse(Console.ReadLine());
            
            
            double soma = obj1.soma();

            if (soma < 60.00){
                Console.WriteLine("O valor da nota final é insuficiente, faltou {0} para o aluno ser aprovado", 60 - soma);
                
            }else if(soma < 60.00){
            Console.WriteLine("Você passou com sucesso, a sua nota final foi {0} ", soma);
        }
    }
        
    }