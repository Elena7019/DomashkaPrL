// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
void Nomer68()
{
    int m = InputNumbers("Введите m (0 <= m <= 3): ");
    int n = InputNumbers("Введите n (0 <= n <= 11): ");
    Console.WriteLine($"Функция Аккермана A({m}, {n}) = {Ackermann(m, n)}");

    int InputNumbers(string output)
    {
        Console.Write(output);
        return int.Parse(Console.ReadLine());
    }
    int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        if (m > 0 && n == 0)
            return Ackermann(m - 1, 1);
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}
Nomer68();