// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Ввeдите значение M");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int [M]; 
void Vvod()
{
    Console.WriteLine($"Ввeдите {M} чисел через enter");
    for (int i = 0; i < M; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
}
void FindPrint()
{
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        if (array[i] > 0)
            {
                count++;
            }
    }
    Console.WriteLine($"Kоличество чисел больше 0 = {count}");   
}
Vvod();
FindPrint();