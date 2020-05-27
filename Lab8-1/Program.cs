using System;

namespace Lab8_1
{
    struct Train
    {
        public string Number; //номер поезда
        public string Name; //название пункта назначения
        public string Date; //время отправления
        public Train(string n,string nm, string d)
        {
            Number = n;
            Name = nm;
            Date = d;
        }
        public override string ToString()
        {
            return $"Номер поезда: {Number}\nПункт назначения: {Name}\nВремя отправления: {Date}";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string num, target, date;
            Console.Write("Введите номер поезда: ");
            num = Console.ReadLine();
            Console.Write("Введите пункт назначения: ");
            target = Console.ReadLine();
            Console.Write("Введите дату отправления: ");
            date = Console.ReadLine();

            Train tr = new Train(num,target,date);
            Console.WriteLine(tr);
        }
    }
}
