double [] DataInput ()
    {
        Console.Write("Введите коээфициент K: ");
        double k = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите коээфициент B: ");
        double b = Convert.ToDouble(Console.ReadLine());
        double [] cofficients = new double [2];
        cofficients [0] = k;
        cofficients [1] = b;
        return cofficients;
    }

double [] FindIntersection (double [] mas_1, double [] mas_2)
    {
        double [] cord = new double [2];
        double numerator = mas_2[1] - mas_1[1];
        double denominator = mas_1[0] - mas_2[0];
        cord [0] = Math.Round(numerator/denominator, 2);
        cord [1] = Math.Round(mas_1[0] * numerator/denominator + mas_1[1], 2);
        return cord;
    }

void PrintArray(double[] mas1)
    {
        Console.WriteLine("Координаты точки пересечения: ");
        for (int i=0; i<mas1.Length;i++)
            {
                if (i != mas1.Length - 1) Console.Write($"{mas1[i]}, ");
                else Console.WriteLine($"{mas1[i]}");
            }
    }
try
    {   
        double [] first_line = DataInput();
        double [] second_line = DataInput();
        double [] result = FindIntersection(first_line, second_line);
        PrintArray(result);

    }
catch
    {
        Console.WriteLine("Введите число в цифровом формате");
    }