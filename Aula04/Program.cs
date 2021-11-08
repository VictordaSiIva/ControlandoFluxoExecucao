using System;

namespace Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean condicao = true;
            int valor;

            while(condicao == true) {
            Console.WriteLine("Digite um valor, 0 ou 10 para sair");
            valor = int.Parse(Console.ReadLine());
                switch (valor)
                {
                    case 0:
                    Console.WriteLine("Você saiu da aplicação");
                    break;
                    case 10:
                    Console.WriteLine("Você saiu da aplicação");
                    break;
                    default:
                    Console.WriteLine("O valor informado é: "+ valor);
                    break;
                }
               
            };
        }
    }
}
