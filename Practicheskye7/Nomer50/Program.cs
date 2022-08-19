// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.
void Nomer50()
{
    Console.WriteLine("Введите номер строки");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");
    int [,] array = new int [10,10];
    FillArray(array);
    PrintArray(array);
    if (n > array.GetLength(0) || m > array.GetLength(1))
    {
        Console.WriteLine("Этот элемент в массиве отсутствует");
    }
    else
    {
        Console.WriteLine($"Значение элемента равно {array[n-1,m-1]}");
    }
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-10, 10);
            }   
        }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }   
        
        Console.WriteLine();
    }
}
Nomer50();