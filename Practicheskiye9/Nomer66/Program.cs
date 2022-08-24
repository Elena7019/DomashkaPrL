// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
Console.Write("Введите значение М: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N, N>M: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма натуральных чисел в промежутке между {M} и {N} равна ");

void SumNatural(int M, int N, int sum)
{
    if (N<M)
    {
        Console.Write(sum);
        return;
    }
    sum = sum + M;
    M++;
    SumNatural(M, N, sum);
}
SumNatural(M, N, 0);