using System;
using System.Collections.Generic;

class Program
{
    static string GenerateProductCode(int counter, int maxChar, int maxDigit)
    {
        char c = (char)((counter / (maxDigit + 1)) + 'A');
        int digit = (counter % (maxDigit + 1));
        return $"{c}{digit}";
    }

    static void Main()
    {
        Console.Write("จำนวนตัวอักษรภาษาอังกฤษ (m): ");
        int maxChar = int.Parse(Console.ReadLine());

        Console.Write("จำนวนเลขโดด (n): ");
        int maxDigit = int.Parse(Console.ReadLine());

        Dictionary<string, string> inventory = new Dictionary<string, string>();

        int counter = 0;
        while (true)
        {
            Console.Write("ชื่อสินค้าที่จะเพิ่มเข้าไปในระบบ (หากต้องการหยุดกรอกให้พิมพ์ 'Stop'): ");
            string productName = Console.ReadLine();
            if (productName == "Stop")
            {
                break;
            }

            string productCode = GenerateProductCode(counter, maxChar, maxDigit);
            inventory[productCode] = productName;
            counter++;
        }

        Console.Write("รหัสสินค้าที่ต้องการค้นหา: ");
        string searchCode = Console.ReadLine();

        if (inventory.ContainsKey(searchCode))
        {
            Console.WriteLine("ชื่อสินค้าที่กำกับด้วยรหัสสินค้า {0}: {1}", searchCode, inventory[searchCode]);
        }
        else
        {
            Console.WriteLine("Not found!");
        }
    }
}
