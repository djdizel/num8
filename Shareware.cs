using System;

namespace num8
{
    class Shareware : Software
    {
        string manufacturer;
        DateTime installDate;
        int freePeriod;
        
        public string Manufacturer { get; set; }
        public DateTime InstallDate { get; set; }
        public int FreePeriod { get; set; }
        
        public Shareware(string name, string manufacturer, DateTime installDate, int freePeriod) : base(name)
        {
            Manufacturer = manufacturer;
            InstallDate = installDate;
            FreePeriod = freePeriod;
        }
        
        public override void Print()
        {
            Console.WriteLine($"Тип: Условно-бесплатное ПО");
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Производитель: {Manufacturer}");
            Console.WriteLine($"Дата установки: {InstallDate.ToShortDateString()}");
            Console.WriteLine($"Срок бесплатного использования: {FreePeriod} дней");
            Console.WriteLine($"Статус: {(IsUsable() ? "Доступно" : "Недоступно")}\n");
        }
        
        public override bool IsUsable()
        {
            DateTime currentDate = new DateTime(2025, 4, 3); 
            TimeSpan diff = currentDate - installDate;
            return diff.Days <= freePeriod;
        }
    }
}