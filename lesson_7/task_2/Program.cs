int [] InputCord ()
    {
        int [] Data =  new int [2];
        Console.Write("Введите индекс колонны: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите строчный индекс: ");
        int raws = Convert.ToInt32(Console.ReadLine());
        Data[0] = columns;
        Data[1] = raws;
        return Data; 
    }

int [,] GenerateMatrix(int m, int n)
    {
        int [,] matrix = new int [n, m];
        int item = 1;
        for (int idx_c = 0; idx_c < matrix.GetLength(0); idx_c++)
            {
                for (int idx_r = 0; idx_r < matrix.GetLength(1); idx_r++)
                    {
                        matrix[idx_c, idx_r] = item;
                        item++;
                    }
            }
        return matrix;
    }

void MatrixPrinter (int [,] matrix_1)
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
object FindByIndex (int [,] matrix_2, int [] data)
    {
        int idx_c_given = data[0];
        int idx_r_given = data[1];
        if (idx_c_given < matrix_2.GetLength(0) && idx_r_given < matrix_2.GetLength(1))
            {
                int number = matrix_2[idx_c_given,idx_r_given];
                return number;
            }
        else return "По заданному индексу элемент не найден";
    }
int [,] my_matrix = GenerateMatrix(3, 4);
MatrixPrinter(my_matrix);
int [] search = InputCord();
object result = FindByIndex(my_matrix, search);
Console.WriteLine(result);

