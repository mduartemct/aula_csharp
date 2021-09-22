using System;

namespace Method_Exercise01
{
    class NestExample
    {
        static void Main()
        {
            Console.WriteLine("a ={0} , area = {1}", 5.33, CircleArea(5.33).ToString("F2"));
            Console.WriteLine("a ={0}, area = {1} ", 9.999, CircleArea(9.999).ToString("F2"));

            Console.WriteLine("{0}", RepeatString("str", 2));
            Console.ReadKey();
        }

        static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;

        }
        static string RepeatString(string str, int count)
        {
            string repeatedString = str;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(repeatedString + "Repeatition " + i);

            }
            return repeatedString;
        }
    }
}
