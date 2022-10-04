double [] ArrayGen(int size)
    {
        double [] mas = new double [size];
        for (int idx = 0;idx < size;idx++)
            {
                mas[idx] = Math.Round(new Random().NextDouble()*100, 2);
            }
        return mas;
    }

void PrintArray(double[] mas1)
    {
        for (int i=0; i<mas1.Length;i++)
            {
                if (i != mas1.Length - 1) Console.Write($"{mas1[i]}, ");
                else Console.WriteLine($"{mas1[i]}");
            }
    }
double FindExtremDif(double[] mas2)
    {
        double max = mas2[0];
        double min = mas2[0];
        foreach(double item in mas2)
        {
            if (item > max) max = item;
            else if (item < min) min = item;
        }
        Console.WriteLine($"Максимальное число в массиве: {max}");
        Console.WriteLine($"Минимальное в массиве: {min}");
        double diff = Math.Round(max - min, 2);
        return diff;
    }
double [] my_array = ArrayGen(12);
PrintArray(my_array);
double array_diff = FindExtremDif(my_array);
Console.WriteLine($"Разница между максимальным и минимальным числом: {array_diff}");
