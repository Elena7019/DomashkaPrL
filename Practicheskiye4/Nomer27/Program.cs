//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
void Zadacha27()
{
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number > 0)
    {
    sum = sum + number % 10;
    number = number /10 ;
    }
 Console.WriteLine("Сумма цифр числа равна " + sum);
}
Zadacha27();