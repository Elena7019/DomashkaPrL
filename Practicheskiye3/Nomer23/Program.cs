﻿// Задача 23. Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Таблица кубов чисел от 1 до "+number);
for (int i = 0; i <= number; i++)
{
    Console.WriteLine(i + "^3 = " + Math.Pow(i,3));
}