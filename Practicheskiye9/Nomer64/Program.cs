// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа кратные 3-ём 
// в промежутке от M до N.

Console.Write("Введите значение М: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Натуральные числа, кратные 3, в промежутке между {M} и {N}: ");
MultThree(M, N);
MultThreeToo(M, N);
void MultThree(int M, int N)
{
if (M<N) return;
  if (M%3 == 0)
    {
      Console.Write ($"{M}" + "; ");
      M = M-3;
    }
  else
    {
      M--;
    }
MultThree(M, N);
}
void MultThreeToo(int M, int N)
{
  if (N<M) return;
  if (M%3 == 0)
  {
  Console.Write ($"{M}" + "; ");
  M=M+3;
  }
  else
  {
   M++;
  }
  MultThreeToo
(M, N);
}
