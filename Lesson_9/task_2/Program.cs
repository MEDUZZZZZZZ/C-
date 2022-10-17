int sum_recurtion (int n, int m)
    {
        if (n == m) return m;
        else return n + sum_recurtion(n+1, m);
    }

Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от {n} до {m} сотсавляет {sum_recurtion(n, m)}");