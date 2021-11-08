using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes;

            Console.WriteLine("Digite um número do mês");
            mes = int.Parse(Console.ReadLine());

            switch(mes){
                case 1:
                Console.WriteLine("Janeiro");
                break;
                case 2: 
                Console.WriteLine("feveiro");
                break;
                case 3: 
                Console.WriteLine("março");
                break;
                case 4: 
                Console.WriteLine("abril");
                break;
                case 5: 
                Console.WriteLine("maio");
                break;
                case 6: 
                Console.WriteLine("junho");
                break;
                case 7: 
                Console.WriteLine("julho");
                break;
                case 8: 
                Console.WriteLine("agosto");
                break;
                  case 9: 
                Console.WriteLine("setembro");
                break;
                  case 10: 
                Console.WriteLine("outubro");
                break;
                  case 11: 
                Console.WriteLine("novembro");
                break;
                case 12: 
                Console.WriteLine("dezembro");
                break;

                default:
                Console.WriteLine("mês inválido");
                break;
            }

           
            
        }
    }
}
