﻿//Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.WriteLine("Введите число 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberB>max) max = numberB;
if (numberC>max) max = numberC;
Console.Write ("max = ");
Console.WriteLine (max);