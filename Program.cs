using System;

namespace md02_CadernoExercicios_05
{
    class Program
    {
        /*
         5. Escrever um algoritmo para ler dois números. Se os números forem iguais imprimir a
            mensagem: “Números iguais” e encerrar a execução; caso contrário, imprimir o de maior
            valor, acompanhando pela mensagem “é maior número”.
         */
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Digite o primeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 == n2)
            {
                Console.WriteLine("Números iguais");
            }
            else
            {
                if (n1 > n2)
                {
                    Console.WriteLine("O maior Valor foi {0}", n1.ToString("0"));
                }
                else
                {
                    Console.WriteLine("O maior Valor foi {0}", n2.ToString("0"));
                }
            }

        }
    }
}
