using System;

namespace Method_Exercise02
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello World!");
    //    }

    //    static int numBeans = 0;
    //    static void ExampleMethod(int x)
    //    {
    //        //int numBeans = 0;
    //        if (x > 1)
    //        {
    //            Console.WriteLine("X é > 1");
    //            return;
    //        }
    //        Console.WriteLine("X é igual ou mnenor que 1");
    //    }

    //    static void ExampleMethod()
    //    {
    //       // int numBeans = 0;
    //        //...
    //        Console.WriteLine("Hello");
    //        if (numBeans < 10)
    //        {
    //            return;
    //        }

    //        Console.WriteLine("World");
    //    }

    //}

    class CallCounter_Bad
    {
        static int nCount = 0;
        static void Init()
        {

        }
        static void CountCalls()
        {
            // int nCount;
            ++nCount;
            Console.WriteLine("Method called {0} time(s)", nCount);
        }
        static void Main()
        {
            for (int i = 0; i < 29; i++)
            {
                CountCalls();
                CountCalls();
            }
            Console.ReadKey();

        }
    }



}
