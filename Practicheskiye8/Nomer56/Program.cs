// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.
void Nomer56()
{
    Random random = new Random();
    int rows = random.Next(4,8);
    int columns = random.Next(4,8);;
    int [,] array = new int [rows, columns];
    FillArray(array);
    Console.WriteLine("Задан массив:");
    PrintArray(array);
    int minsum = Int32.MaxValue;
    int indexLine = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];        
        }
            if (sum < minsum)
            {
                minsum = sum;
                indexLine++;
            }
    }


Console.WriteLine("Cтрока с наименьшей суммой элементов номер " + (indexLine) + ", сумма элементов равна " + (minsum));
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}
Nomer56();
