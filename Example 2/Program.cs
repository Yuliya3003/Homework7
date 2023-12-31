﻿// Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Enter(string message) {
    Console.WriteLine(message);
    double x = int.Parse(Console.ReadLine());
    return x;
}
double b1 = Enter("Введите b1");
double k1 = Enter("Введите k1");
double b2 = Enter("Введите b2");
double k2 = Enter("Введите k2");

double x = (b2-b1)/(k1-k2);
double y1 = k1*(b2-b1)/(k1-k2) + b1;
double y2 = k2*(b2-b1)/(k1-k2) + b2;

if (k1 ==k2 && b1 == b2){
Console.WriteLine("Прямые совпадают");
} 
else if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
if (y1 == y2) {
    Console.WriteLine($"({(b2-b1)/(k1-k2)}, {y1})");
}
