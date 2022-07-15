//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int startnumber = 1;
while(startnumber != (number + 1))
{
    Console.Write(startnumber + ",");
    startnumber+=1;
}
Console.Write("\b.");