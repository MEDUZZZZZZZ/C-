int [] GetSizes ()
    {
        int [] Data =  new int [2];
        Console.Write("Введите колличество столбцов: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите колличество строк: ");
        int raws = Convert.ToInt32(Console.ReadLine());
        Data[0] = columns;
        Data[1] = raws;
        return Data;
    }
double [,] MatrixGen (int [] sizes)
    {
        int columns = sizes[0];
        int raws = sizes[1];
        double [,] matrix = new double [columns, raws];
        for (int idx_c = 0; idx_c < matrix.GetLength(0); idx_c++)
            {
                for (int idx_r = 0; idx_r < matrix.GetLength(1); idx_r++)
                    {
                        matrix[idx_c,idx_r] = Math.Round(new Random().NextDouble()*10-5,1);
                    }
            }
        return matrix;
    }

void DoubleMatrixPrinter (double [,] matrix_1)
{
    Console.WriteLine("Исходная матрица");
    for (int idx_c = 0; idx_c < matrix_1.GetLength(0); idx_c++)
        {
            for (int idx_r = 0; idx_r < matrix_1.GetLength(1); idx_r++)
                {
                    Console.Write($" {matrix_1[idx_c, idx_r]} ");
                }
            Console.WriteLine();
        }
}
int [] sizes_array = GetSizes();
double [,] my_matrix = MatrixGen(sizes_array);
DoubleMatrixPrinter(my_matrix);


