using System;

namespace DesignPattern.Delegate
{
    public delegate int Calc(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc(Add);
            int result = calc(1, 2);
            Console.WriteLine(result);

            calc = Subtract;
            result = calc(1, 2);
            Console.WriteLine(result);

            calc = Multiply;
            result = calc(1, 2);
            Console.WriteLine(result);
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
