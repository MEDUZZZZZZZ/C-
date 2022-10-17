int LeviAkkerman (int m, int n)
    {
        if (m == 0) return n + 1;
        if (n == 0) return LeviAkkerman(m-1,1);
        return LeviAkkerman(m-1, LeviAkkerman(m, n-1));
    }

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"m = {m}, n = {n} --> A({m},{n}) = {LeviAkkerman(m,n)}");

