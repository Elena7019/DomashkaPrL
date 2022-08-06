// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
void Number34()
{
    int size = 8;
    Random random = new Random();
    int[] array = new int[size];
    int sum = 0;
    Console.WriteLine("Случайный массив состоит из следующих цифр: ");
        for (int i =0; i < array.Length; i++)
        {
            array[i] = random.Next(100,1000);
            Console.WriteLine(array[i] + " ");
        }
        for (int i =0; i < array.Length; i++)
            {
            if (array[i]%2 == 0)
                {
                sum = sum + 1;
                }
            }
    Console.WriteLine ($"Количество четных чисел = {sum}");
    }

Number34();

/*int size = 10;
int sum  = 0;
int[] array = new int [size];
Random random = new Random();
    for (int i =0; i < size; i++)
    {
        array[i] = random.Next(-10, 10);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    for (int i =1; i < array.Length; i=i+2)
        {
            sum = sum + array[i];
        }
    Console.WriteLine("Сумма элементов, стоящих на нечётных позициях, равна " + sum );*/