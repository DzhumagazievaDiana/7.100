using System;
public class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Количество целых чисел:");
        var n = int.Parse(Console.ReadLine());
        int S = 0;
        Console.WriteLine("Введите число m:");
        var m = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите число p:");
        var p = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            int d = i;
            if (d <= m) S += d;
            Console.WriteLine(S % p == 0? $"\n{S} кратно {p}" : $"\n{S} не кратно {p}");
        }
        Console.ReadKey();
    }
}
