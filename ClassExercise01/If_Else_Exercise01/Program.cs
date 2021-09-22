using System;

namespace If_Else_Exercise01
{
    class Program
    {
        private static bool ended = false;

        static int x = 10;
        static void Main(string[] args)
        {

            var b = x;
            while (!ended)
            {
                Console.WriteLine("Passe um valor de -9 até 9.");

                var valor = int.Parse(Console.ReadLine());

                if ((valor == 0 && 1 > valor) || valor < 4)
                    Console.WriteLine(true);
                else
                    Console.WriteLine(false);

                Console.WriteLine("Deseja Jogar outra vez? 1 para Sim e 2 para Não.");
                if (Console.ReadLine() == "2")
                {
                    ended = true;
                }

            }

            Console.WriteLine("End game!!!");
            Console.ReadKey();

        }
    }
}
