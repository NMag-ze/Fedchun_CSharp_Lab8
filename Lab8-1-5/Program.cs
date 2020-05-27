using System;

namespace Lab8_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 5;
                int y = x / 2;
                Console.WriteLine($"Результат: {y}");
            }
            catch(Exception ex)
            {
                Console.Beep();
                Console.WriteLine("Возникло исключение:\n{0}",ex.Message);
            }
            finally
            {
                Console.WriteLine("Блок finally");
            }
            Console.WriteLine("Конец программы");
            Console.Read();
        }
    }
}
