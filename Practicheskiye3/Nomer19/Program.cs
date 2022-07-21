 //Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
 //является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit1 = number/10000;
int digit2 = (number - digit1*10000)/1000;
int digit3 = (number - digit1*10000 - digit2*1000)/100;
int digit4 = (number - digit1*10000 - digit2*1000 - digit3*100)/10;
int digit5 = number - digit1*10000 - digit2*1000 - digit3*100- digit4*10;
if (digit1 == digit5 && digit2 == digit4)
{
  Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом"); 
} 
