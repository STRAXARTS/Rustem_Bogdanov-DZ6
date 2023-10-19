// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Введите K1: ");
int K1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите K2: ");
int K2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B1: ");
int B1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B2: ");
int B2 = Convert.ToInt32(Console.ReadLine());
double B = B2-B1;
double K = K1-K2;
double X = B/K;
double Y = K1*X+B1;
Console.Write($"Точка пересечения имеет координаты ({X}, {Y})");