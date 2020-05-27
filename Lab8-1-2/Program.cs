using System;

namespace Lab8_1_2
{
    struct Train
    {
        public string Number; //номер поезда
        public string Name; //название пункта назначения
        public string Date; //время отправления
        public enum typeTrain
        {
            skTrain, //скоростной
            pasTrain, //пассажирский
            tTrain, //товарный
        };
        typeTrain ty;

        public Train(string n, string nm, string d, typeTrain t)
        {
            Number = n;
            Name = nm;
            Date = d;
            ty = t;
        }
        public override string ToString()
        {
            return $"Номер поезда: {Number}\nТип поезда: {ty}\nПункт назначения: {Name}\nВремя отправления: {Date}";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string num, target, date;
            string type;
            Train.typeTrain ty=0; //по умолчанию Скоростной
            Console.Write("Введите номер поезда: ");
            num = Console.ReadLine();
            Console.Write("Введите тип поезда: ");
            type = Console.ReadLine();
            switch(type)
            {
                case "Скорый": ty = Train.typeTrain.skTrain;break;
                case "Пассажирский": ty = Train.typeTrain.pasTrain; break;
                case "Товарный": ty = Train.typeTrain.tTrain; break;
                default:break;
            }
            Console.Write("Введите пункт назначения: ");
            target = Console.ReadLine();
            Console.Write("Введите дату отправления: ");
            date = Console.ReadLine();

            
            Train tr = new Train(num, target, date, ty);
            Console.WriteLine(tr);
        }
    }
}
