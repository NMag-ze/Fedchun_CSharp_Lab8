using System;
//List-Value-Types
namespace Lab8_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            SByte a = 0;
            Byte b = 5;
            Int16 c = 14;
            Int32 d = 246;
            Int64 e = 7251;
            String s = "";
            Exception ex = new Exception();

            Object[] types = { a, b, c, d, e, s, ex };
            Console.WriteLine("Значимые типы:");
            foreach (object o in types)
            {
                if (o.GetType().IsValueType) Console.WriteLine(o.GetType().Name);
            }
        }
    }
}
