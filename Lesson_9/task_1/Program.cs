string RowOfNaturals (int n)
    {
        if (n == 1) return "1.";
        else return ($"{n}," + $" {RowOfNaturals(n-1)}");
    }

Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ряд натуральных чисел от 1 до {m}: ");
Console.WriteLine(RowOfNaturals(m));