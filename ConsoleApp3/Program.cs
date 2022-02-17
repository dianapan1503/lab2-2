using System;

namespace ConcoleApp3
{
    class Program
    {
        public delegate int MyDelegate(int firstNum, int secondNum);
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введіть перше число: ");
                    int firstArg = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n");
                    Console.Write("Введіть друге число: ");
                    int secondArg = Convert.ToInt32(Console.ReadLine());

                    Method(firstArg, secondArg);
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
        }
        static void Method(int firstArg, int secondArg)
        {

            MyDelegate myDelegate = (int x, int y) => { return x + y; };
            MyDelegate myDelegate2 = (int x, int y) => { return x - y; };
            MyDelegate myDelegate3 = (int x, int y) => { return x * y; };
            MyDelegate myDelegate4 = (int x, int y) => { return x / y; };


            Console.Write("\n");
            Console.Write("Введдіть знак операції (+, -, *, /) ");
            string sign = Console.ReadLine();
            Console.Write("\n");
            if (sign == "+")
            {
                Console.WriteLine($"{firstArg} + {secondArg} = {myDelegate(firstArg, secondArg)}");
            }
            else if (sign == "-")
            {
                Console.WriteLine($"{firstArg} - {secondArg} = {myDelegate2(firstArg, secondArg)}");
            }
            else if (sign == "*")
            {
                Console.WriteLine($"{firstArg} * {secondArg} = {myDelegate3(firstArg, secondArg)}");
            }
            else if (sign == "/")
            {
                if (secondArg == 0)
                {
                    Console.WriteLine("Ділить на нуль не можна!");
                }
                else
                {
                    Console.WriteLine($"{firstArg} / {secondArg} = {myDelegate4(firstArg, secondArg)}");
                }
            }
        }
    }
}