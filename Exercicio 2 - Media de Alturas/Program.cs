using System;

namespace Exercicio_2___Media_de_Alturas
{
    class Program
    {
        static void Main(string[] args)
        {

            bool opcao = true;

            while (opcao == true)
            {
                //Entrada dos números a serem calculados.
                Console.WriteLine("Escreva a altura 1: ");
                float.TryParse(Console.ReadLine(), out float n1);
                
                Console.WriteLine("Escreva a altura 2: ");
                float.TryParse(Console.ReadLine(), out float n2);

                Console.WriteLine("Escreva a altura 3: ");
                float.TryParse(Console.ReadLine(), out float n3);

                Console.WriteLine("Escreva a altura 4: ");
                float.TryParse(Console.ReadLine(), out float n4);

                Console.WriteLine("Escreva a altura 5: ");
                float.TryParse(Console.ReadLine(), out float n5);


                //Calculando soma e a médias das alturas 

                float soma = (n1 + n2 + n3 + n4 + n5);
                Console.WriteLine("\n A soma total das alturas é: ");
                Console.WriteLine(soma);
                
                float media = (soma/5);
                Console.WriteLine("\n A média das alturas é: ");
                Console.WriteLine(media);


                //Menu para finalizar ou continuar o teste.
                Console.WriteLine("\n Deseja sair do teste?\n 1 - Sim.\n 2 - Não.");
                int.TryParse(Console.ReadLine(), out int saida);
                switch (saida)
                {

                    case 1:
                        Console.WriteLine("Saindo do programa.\n");
                        opcao = false;
                        break;
                    case 2:
                        Console.WriteLine("Continuando o teste.\n");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida. Retornando ao teste.\n");
                        break;
                }
            } 

        }
    }
}
