using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Software> softwareBase = new List<Software>
            {
                new FreeSoftware("Linux", "Community"),
                new Shareware("WinRAR", "RARLAB", new DateTime(2025, 3, 24), 30), // 10 дней назад
                new Commercial("Photoshop", "Adobe", 9999.99, new DateTime(2025, 2, 22), 365), // 40 дней назад
                new Shareware("Norton", "Symantec", new DateTime(2025, 2, 22), 30) // 40 дней назад
            };

            Console.WriteLine("=== Вся база программного обеспечения ===\n");
            foreach (var software in softwareBase)
            {
                software.Print();
            }

            Console.WriteLine("=== Доступное на 03.04.2025 программное обеспечение ===\n");
            foreach (var software in softwareBase)
            {
                if (software.IsUsable())
                {
                    Console.WriteLine($"Название: {software.Name}\n");
                }
            }

            Console.ReadLine();
        }
    }
}
