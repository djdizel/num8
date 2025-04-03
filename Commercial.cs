using System;

namespace num8
{
    class Commercial : Software
    {
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public DateTime InstallDate { get; set; }
        public int UsagePeriod { get; set; }
        
        public Commercial(string name, string manufacturer, double price, DateTime installDate, int usagePeriod) : base(name)
        {
            Manufacturer = manufacturer;
            Price = price;
            InstallDate = installDate;
            UsagePeriod = usagePeriod;
        }
        
        public override void Print()
        {
            Console.WriteLine($"Тип: Коммерческое ПО");
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Производитель: {Manufacturer}");
            Console.WriteLine($"Цена: {Price} руб.");
            Console.WriteLine($"Дата установки: {InstallDate.ToShortDateString()}");
            Console.WriteLine($"Срок использования: {UsagePeriod} дней");
            Console.WriteLine($"Статус: {(IsUsable() ? "Доступно" : "Недоступно")}\n");
        }

        public override bool IsUsable()
        {
            DateTime currentDate = new DateTime(2025, 4, 3); 
            TimeSpan diff = currentDate - InstallDate;
            return diff.Days <= UsagePeriod;
        }
    }
}