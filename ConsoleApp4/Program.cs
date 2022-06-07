using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите день: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите месяц: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Введите год: ");
        int c = int.Parse(Console.ReadLine());
        var calJul = new DateTime(c, b, a);
        var calGri = calJul.AddDays((c / 100) - ((c / 100) / 4) - 2);
        Console.WriteLine("Юлианский календарь - " + calJul.ToLongDateString());
        Console.WriteLine("Современный календарь - " + calGri.ToLongDateString());
    }
}