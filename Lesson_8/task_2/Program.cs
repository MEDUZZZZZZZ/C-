int [,] DoubleMatrixMaker ()
    {
        Console.Write("Введите число столбцов: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число строк: ");
        int raws = Convert.ToInt32(Console.ReadLine());
        while (columns == raws) 
            {
                Console.Write("Матрица должна быть прямоугольной введите другое число строк: ");
                raws = Convert.ToInt32(Console.ReadLine());
            }   
        int [,] matrix = new int [raws, columns];
        for (int idx_c = 0; idx_c < matrix.GetLength(0); idx_c++)
            {
                for (int idx_r = 0; idx_r < matrix.GetLength(1); idx_r++)
                    {
                        matrix[idx_c,idx_r] = new Random().Next(1, 10);
                    }
            }
        return matrix;
    }
void DoubleMatrixPrinter (int [,] matrix_1)
    {
        Console.WriteLine("Матрица: ");
        for (int idx_c = 0; idx_c < matrix_1.GetLength(0); idx_c++)
            {
                for (int idx_r = 0; idx_r < matrix_1.GetLength(1); idx_r++)
                    {
                        Console.Write($" {matrix_1[idx_c, idx_r]} ");
                    }
                Console.WriteLine();
            }
    }
int FindMinSumRaw(int [,] matrix_1)
{
    int [] sum_mas = new int [matrix_1.GetLength(0)];
    for (int idx_c = 0; idx_c < matrix_1.GetLength(0); idx_c++) 
        {
            int sum = 0;
            for (int idx_r = 0; idx_r < matrix_1.GetLength(1); idx_r++)
                {
                    sum += matrix_1[idx_c,idx_r];
                }
            sum_mas[idx_c] = sum;
        }
    int min = sum_mas[0];
    int min_raw = 0;
    foreach (int item in sum_mas)
        {
            if (item < min) min = item;
            min_raw = Array.IndexOf(sum_mas,min) + 1;
        }
    return min_raw;
}
int [,] my_matrix = DoubleMatrixMaker();
DoubleMatrixPrinter(my_matrix);
int minimal_sum_raw = FindMinSumRaw(my_matrix);
Console.WriteLine($"Минимальная сумма элементов наблюдается в строке номер: {minimal_sum_raw}");


