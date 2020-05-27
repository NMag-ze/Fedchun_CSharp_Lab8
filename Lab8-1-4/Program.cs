using System;
//SortString
namespace Lab8_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Укроп Арбуз Ежевика Яблоко";
            Console.WriteLine(s);
            string[] sa = s.Split(" ");
            Array.Sort(sa);
            s = String.Join(" ",sa);
            Console.WriteLine(s);
        }
    }
}
