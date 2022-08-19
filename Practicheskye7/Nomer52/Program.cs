//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Nomer52()
{
    int n = 5;
    int m = 6;
    int[,] array = new int[n, m];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine("Среднее арифметическое столбцов массива:");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double average = 0;  
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average = (average  + array[i, j]);
        }
        average = average / n;
        Console.Write(average + "\t");
}
Console.WriteLine();

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
}
Nomer52();