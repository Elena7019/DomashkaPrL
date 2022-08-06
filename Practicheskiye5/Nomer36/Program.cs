// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
int size = 10;
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
    Console.WriteLine("Сумма элементов, стоящих на нечётных позициях, равна " + sum );