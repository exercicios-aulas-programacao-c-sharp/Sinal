using System;

namespace Sinal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            //Entrada do usuário
            //Estrutura condicional requerida

            int numero;

            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("Positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("Negativo");
            }
            else
            {
                Console.WriteLine("Zero");
            }

        }
    }
}
