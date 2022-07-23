// Напишите программу, которая задаёт массив из 8 элементов и выводит отсортированный по модулю массив
void MyArray()
{
    int size = 8;
    Random random = new Random();
    int[] array = new int[size];
        for (int i =0; i < array.Length; i++)
    {
        array[i] = random.Next(-100,10);
    }
    for (int i =0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            array[i] = - array[i];
        }
        Console.Write ("[" + array[i] + "]");
    }

}

MyArray();