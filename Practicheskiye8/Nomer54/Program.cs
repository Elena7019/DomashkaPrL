//Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива
void Nomer54()
{
    Random random = new Random();
    int rows = random.Next(4,8);
    int columns = random.Next(4,8);
    int [,] array = new int [rows, columns];
    FillArray(array);
    Console.WriteLine("Задан массив:");
    PrintArray(array);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int l = 0; l < array.GetLength(1) - 1; l++)
            {
                if (array[i, l] < array[i, l + 1])
                {
                    int temp = 0;
                    temp = array[i, l];
                    array[i, l] = array[i, l + 1];
                    array[i, l + 1] = temp;
                }
            }
        }
    }
    Console.WriteLine("Массив с упорядоченными значениями каждой строки по убыванию");
    PrintArray(array);

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
            Console.Write(array[i, j] + "\t ");
        }
            Console.WriteLine("");
    }
}
}
Nomer54();