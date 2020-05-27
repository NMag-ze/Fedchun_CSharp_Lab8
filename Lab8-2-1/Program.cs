using System;

namespace Lab8_2_1
{
    class Train
    {
        private string number; //номер поезда
        private string name; //название пункта назначения
        private string date; //время отправления
       
        public string Number
        {
            set { number = value; }
            get { return number; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Date
        {
            set { date = value; }
            get { return date; }
        }
        public Train()
        {

        }
        public Train(string n, string nm, string d)
        {
            number = n;
            name = nm;
            date = d;
        }
        public override string ToString()
        {
            return $"Номер поезда: {Number}\nПункт назначения: {Name}\nВремя отправления: {Date}";
        }

    }

    class FirmTrain : Train
    {
        public string nameFirm;
        public double kPrice;

        public FirmTrain(string number,string name,string date,string firm,double koef):base(number,name,date)
        {
            nameFirm = firm;
            kPrice = koef;
        }
        public override string ToString()
        {
            return $"Номер поезда: { Number}\nПункт назначения: { Name}\nВремя отправления: {Date}\nФирменное название: {nameFirm}\nКоэффициент удорожания: {kPrice}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string num, target, date;
            string firm;
            double koef;
            Console.Write("Введите номер поезда: ");
            num = Console.ReadLine();
            Console.Write("Введите пункт назначения: ");
            target = Console.ReadLine();
            Console.Write("Введите дату отправления: ");
            date = Console.ReadLine();
            Console.Write("Введите фирменное название: ");
            firm = Console.ReadLine();
            Console.Write("Введите коэффициент удорожания: ");
            koef = double.Parse(Console.ReadLine());

            Console.WriteLine();
            FirmTrain tr = new FirmTrain(num, target, date, firm, koef);
            Console.WriteLine(tr);
        }
    }
}
