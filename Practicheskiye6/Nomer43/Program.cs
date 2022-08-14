// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

void Zadacha43()
{
    Random random = new Random();
    int x = random.Next(-10, 11);
    int y = random.Next(-10, 11);
    Console.WriteLine("Ввeдите значение b1");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ввeдите значение k1");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ввeдите значение b2");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ввeдите значение k2");
    int k2 = Convert.ToInt32(Console.ReadLine());
            if (k1 == k2 && b1 != b2)
            {
                Console.WriteLine("Прямые не пересекаются");
            }
            else
            {
                if(k1 == k2 && b1 == b2)
                {
                    Console.WriteLine("Прямые совпадают");
                }
                else
                {
                    double x0 = (double)Math.Sqrt(Math.Pow((b2-b1)/(k1-k2), 2));
                    double y0 = (double)Math.Sqrt(Math.Pow((k1 * x0 + b1), 2));
                    Console.WriteLine("Координаты точки пересечения прямых " + "(" + Math.Round (x0, 1) + ", " + Math.Round (y0, 1) + ")");
                }
            }
}
Zadacha43();