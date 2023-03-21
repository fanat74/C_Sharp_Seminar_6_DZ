// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите число b1");
Console.Write("число b1=");
double numberB1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k1");
Console.Write("число k1=");
double numberK1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b2");
Console.Write("число b2=");
double numberB2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k2");
Console.Write("число k2=");
double numberK2 = Convert.ToDouble(Console.ReadLine());

double CoordinateY(double a, double b, double c, double d)
{
    double y = ((a - c) * (-1) / (b - d)) * b + a;
    return y;
}
double CoordinateX(double a, double b, double c, double d)
{
    double x = (a - c) * (-1) / (b - d);
    return x;
}

double coordinateX = CoordinateX(numberB1, numberK1, numberB2, numberK2);
double coordinateY = CoordinateY(numberB1, numberK1, numberB2, numberK2);
Console.WriteLine($"Точка пересечения прямых имеет координаты ({coordinateX}; {coordinateY})");
