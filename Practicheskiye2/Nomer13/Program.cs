//Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number< 100)
{
    Console.WriteLine("В заданном числе нет третьей цифры");
}
else
{
    while (number> 999)
    {
    number/= 10;
    }
    Console.WriteLine("Третья цифра " + number%10);
}