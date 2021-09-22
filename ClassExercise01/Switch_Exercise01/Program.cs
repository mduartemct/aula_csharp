using System;

namespace Switch_Exercise01
{
    class Program
    {
        private static bool ended = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Week Days!");


            while (!ended)
            {
                Console.WriteLine("Digite o nr do dia da semana!");

                int day = int.Parse(Console.ReadLine());

                switch (day)
                {
                    case 1:
                        Console.WriteLine("Domingo-Praia");
                        break;

                    case 2:
                        Console.WriteLine("Segunda-Feira");
                        break;

                    case 3:
                        Console.WriteLine("Terça-Feira");
                        break;

                    case 4:
                        Console.WriteLine("Quarta-Feira");
                        break;

                    case 5:
                        Console.WriteLine("Quinta-Feira");
                        break;

                    case 6:
                        Console.WriteLine("Sexta-Feira");
                        break;

                    case 7:
                        Console.WriteLine("Sábado");
                        break;

                    default:
                        Console.Beep(10, 1000);
                        break;
                }

                Console.WriteLine("Deseja Jogar outra vez? 1 para Sim e 2 para Não.");
                if (Console.ReadLine() == "2")
                {
                    ended = true;
                }
            }

        }
    }
}
