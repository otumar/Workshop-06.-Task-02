// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

int Prompt(string massage)
{
    System.Console.Write(massage);
    string param = Console.ReadLine();
    return int.Parse(param);
}

double k1 = Prompt ("Задайте значение k1: ");
double k2 = Prompt ("Задайте значение k2: ");
double b1 = Prompt ("Задайте значение b1: ");
double b2 = Prompt ("Задайте значение b2: ");

if (k1==k2 && b1!= b2) Console.WriteLine("Прямые паралельны");
if (k1==k2 && b1==b2) Console.WriteLine("Прямые накладываются друг на друга");
else 
{
double x = (b2-b1) / (k1-k2);
double y = k1 * x + b1;
Console.WriteLine($"Точка пересечения двух прямых = ({x};{y})");
}