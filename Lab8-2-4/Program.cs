using System;

namespace Lab8_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16 a = 27334;
            Int32 b = 31424151;
            double c = 23.4152;
            Console.WriteLine("{0} {1} {2}", a, b, c);
            Int32 a1 = a;
            double a2 = a;
            Int16 b1 = (Int16)b;
            double b2 = b;
            Int16 c1 = (Int16)c;
            Int32 c2 = (Int32)c;
            Console.WriteLine("{0} {1}\n{2} {3}\n{4} {5}", a1, a2, b1, b2, c1, c2);
        }
    }
}
