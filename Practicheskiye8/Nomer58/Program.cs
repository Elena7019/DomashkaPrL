// Задача 58. Заполните спирально массив 4 на 4
void Nomer58()
{
    Console.Write("Введите размер массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    int columns = rows;
    int [,] matrix = new int[rows, columns];
    int row = 0;
    int column = 0;
    int tempRow = 0;
    int tempColumn = 1;
    int steps = columns;
    int change = 0;
    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[row, column] = i + 1;
        steps--;
        if (steps ==0)
        {
            steps = rows - 1 - change/2;
            int temp = tempRow;
            tempRow = tempColumn;
            tempColumn = -temp;
            change++;
        }
        row += tempRow;
        column += tempColumn;
    }
Console.WriteLine("Заполненный спирально квадратный массив выглядит так:");
Printmatrix(matrix);
}
void Printmatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}
Nomer58();