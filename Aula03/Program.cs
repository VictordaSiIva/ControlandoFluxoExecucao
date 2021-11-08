using System;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] lista = {1,2,3,4,5};

           foreach(int numero in lista)
           {

               Console.WriteLine(numero);
           }
        }
    }
}
           

        //     Boolean condicao = true;
        //     int valor;

        //     do {
        //     Console.WriteLine("Digite um valor, 0 para sair");
        //     valor = int.Parse(Console.ReadLine());

        //         if(valor == 0){
        //              Console.WriteLine("Você saiu da aplicação");
        //             condicao = false;
        //         }
        //         else {
        //          Console.WriteLine("O valor informado é: "+ valor);

        //         }
        //     } while(condicao == true);
        // }
    

