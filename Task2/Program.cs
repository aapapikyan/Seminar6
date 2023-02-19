// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputDouble(string message)
{
    Console.Write($"{message}: ");
    return double.Parse(Console.ReadLine());
}
double k1 = InputDouble("Введите значение коэффициента k1 ");
double b1 = InputDouble("Введите значение коэффициента b1 ");
double k2 = InputDouble("Введите значение коэффициента k2 ");
double b2 = InputDouble("Введите значение коэффициента b2 ");
if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают");
}
else
{
    if (k1 == k2)
    {
        Console.WriteLine("Прямые не пересекаются");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Координаты точки пересечения прямых: ({x}; {y})");
    }
}
