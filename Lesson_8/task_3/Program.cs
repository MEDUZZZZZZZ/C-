int [,] MatrixMultiplicator( int [,] matrix_1, int [,] matrix_2)
    {
        int [,] result_matrix = new int [matrix_2.GetLength(1),matrix_1.GetLength(0)]; 
        for (int idx_c = 0; idx_c < matrix_1.GetLength(0); idx_c++)
            {
                for (int idx_r = 0; idx_r < matrix_2.GetLength(1); idx_r++)
                    {
                        for (int idx_c_2 = 0; idx_c_2 < matrix_2.GetLength(0); idx_c_2++)
                        {
                            result_matrix[idx_c,idx_r] += matrix_1[idx_c,idx_c_2] * matrix_2[idx_c_2,idx_r];
                        } 
                    }
            }
        return result_matrix;
    }
void DoubleMatrixPrinter (int [,] matrix_1)
    {
        for (int idx_c = 0; idx_c < matrix_1.GetLength(0); idx_c++)
            {
                for (int idx_r = 0; idx_r < matrix_1.GetLength(1); idx_r++)
                    {
                        Console.Write($" {matrix_1[idx_c, idx_r]} ");
                    }
                Console.WriteLine();
            }
    }
int [,] my_matrix_1 = new int [,] {{2,4},{3,2},{3,4}};
Console.WriteLine("Исходная матрица 1");
DoubleMatrixPrinter(my_matrix_1);
int [,] my_matrix_2 = new int [,] {{3,4,5},{3,3,3}};
Console.WriteLine("Исходная матрица 2");
DoubleMatrixPrinter(my_matrix_2);
int [,] result = MatrixMultiplicator(my_matrix_1,my_matrix_2);
Console.WriteLine("Результирующая матрица");
DoubleMatrixPrinter(result);
