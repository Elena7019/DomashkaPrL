// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
int size = 8;
double res  = 0;
double[] array = new double [size];
double min = 0;
double max = 0;
Random random = new Random();
void FillPrintDouble()
    {
    for (int i =0; i < size; i++)
        {
        array[i] = random.Next(-10,10) + random.NextDouble();
        Console.Write(array[i] + " ");
        }
    Console.WriteLine();
    }
void Res()
    {
    for (int i = 0; i < array.Length; i++)
        {
        if (min > array[i])
            {
            min = array[i];
            }
        else if (max < array[i])
            {
            max = array[i];
            }
            res = max - min;
        }
    Console.Write("min = " + min + " max = " + max);
    Console.WriteLine();
    Console.WriteLine("Разница между максимальным и минимальным числами массива равна " + res);
    }
    FillPrintDouble();
    Res();