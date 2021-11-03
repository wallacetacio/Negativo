using System;

namespace Negativo
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;

            Console.Write("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num < 0){
                Console.Write("Você digitou um número ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("negativo.");
                Console.ResetColor();
            }
            else
            {
                Console.Write("O número que você digitou ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("não é negativo.");
                Console.ResetColor();

            }

        }
    }
}
