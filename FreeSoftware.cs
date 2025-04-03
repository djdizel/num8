using System;
using System.Collections.Generic;

namespace num8
{
     class FreeSoftware : Software
    {
        string manufacturer;
        
        public string Manufacturer { get; set; }

        public FreeSoftware(string name,string manufacturer) : base(name)
        {
            Manufacturer = manufacturer;
        }
        
        public override void Print()
        {
            Console.WriteLine($"Тип: Свободное ПО");
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Производитель: {manufacturer}");
            Console.WriteLine($"Статус: Всегда доступно\n");
        }
        
        public override bool IsUsable()
        {
            return true; 
        }
    }
}