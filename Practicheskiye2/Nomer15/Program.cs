//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5)
{
    Console.WriteLine("Будний день");
}
else if (number == 6 || number == 7)
{
    Console.WriteLine("Выходной");
}
else
    Console.WriteLine("Ошибка ввода");