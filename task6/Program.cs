using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите сумму вклада:");
        decimal сумма = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Введите количество месяцев:");
        int количество_месяцев = Convert.ToInt32(Console.ReadLine());

        for (int месяц = 1; месяц <= количество_месяцев; месяц++)
        {
            сумма += сумма * 0.07m; // начисление 7% процентов
        }

        Console.WriteLine($"Итоговая сумма вклада после {количество_месяцев} месяцев: {сумма:C}");
    }
}
