//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
void Zadacha21()
{
Random random = new Random();
int x1 = random.Next(-10, 11);
int y1 = random.Next(-10, 11);
int z1 = random.Next(-10, 11);
int x2 = random.Next(-10, 11);
int y2 = random.Next(-10, 11);
int z2 = random.Next(-10, 11);
Console.WriteLine("Координаты первой точки (" + (x1) + "," + (y1) + "," + (z1) + ")");
Console.WriteLine("Координаты второй точки (" + (x2) + "," + (y2) + "," + (z2) + ")");
double result = (double)Math.Sqrt(Math.Pow((x2-x1), 2)+ Math.Pow((y2-y1), 2)+Math.Pow((z2-z1),2));
Console.WriteLine("Расстояние между точками равно " + Math.Round (result, 2));
}


Zadacha21();