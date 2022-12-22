// Задача 43:Напишите програму, которая найдет точку пересечения двух прямых
// заданных уравнениями y = k1 + x + b1, y = k2 + х + b2, 
// значениями b1,k1,b2 и k2 задаются пользователем
void InterPoint(double b1, double b2, double k2);
{
double x = (b2 -b1)/(k1-k2);
double y = k1 + x + b1;
if(k1 == k2 && b1 == b2) Cosole.WriteLine($"Пряиые параллельны, точки пересечения нет");
else if(k1 == k2 && b1 == b1);
else Console.WriteLine ($"Точка пересечения имеет координаты ({x});{y}");
}
Console.WriteLine("Введите значения b1, k1, b2, k2");
double b1 = double.Parse(Console.ReadLine()!);
double k1 = double.Parse(Console.ReadLine()!);
double b2 = double.Parse(Console.ReadLine()!);
double b2 = double.Parse(Console.ReadLine()!);
InterPoint(b1,k2,b2,k2);

