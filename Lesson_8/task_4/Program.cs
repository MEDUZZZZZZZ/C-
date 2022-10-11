int [,,] Matrix3DBuilder()
    {
        Console.Write("Введите число столбцов: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число строк: ");
        int raws = Convert.ToInt32(Console.ReadLine());
        Console.Write("Задайте глубину: ");
        int deep = Convert.ToInt32(Console.ReadLine());
        int [,,] matrix = new int [deep, raws, columns];
        int lower = 10;
        for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        for (int k = 0; k < matrix.GetLength(2); k++)
                            {
                                matrix[i,j,k] = lower;
                                lower += (new Random().Next(1,3));
                            }
                    }
            }
        return matrix;
    }
void Matrix3DPrinter (int [,,] matrix_1)
    {
        Console.WriteLine("Элементы матрицы и их индексы ");
        for (int i = 0; i < matrix_1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_1.GetLength(1); j++)
                    {
                        for (int k = 0; k < matrix_1.GetLength(2); k++)
                            {
                                Console.Write($"Элемент {matrix_1[i, j, k]} Индекс: ({i}, {j}, {k}) ");
                            }
                        Console.WriteLine();
                    }
                Console.WriteLine();
            }           
    }    
int [,,] my_matrix = Matrix3DBuilder();
Matrix3DPrinter(my_matrix);