using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public delegate int MyDel(int a, int b, int c);
        static void Main(string[] args)
        {
            MyDel myDel = delegate (int a, int b, int c)
            {
                return (a + b + c) / 3;
            };

            int result = myDel(2, 4, 6);
            Console.WriteLine(result);
            Console.ReadKey();
        }

    }
}
