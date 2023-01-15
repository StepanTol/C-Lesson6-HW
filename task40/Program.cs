/* Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины. 
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двухдругих сторон. */

Console.WriteLine($"Первая сторна треугольника: ");
int AB = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Первая сторна треугольника: ");
int BC = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Первая сторна треугольника: ");
int AC = int.Parse(Console.ReadLine()!);
GetTriangle(AB, BC, AC);   
void GetTriangle(int a, int b, int c)
{
    if (a<b+c & b<a+c & c<a+b)
    {
        Console.WriteLine($"Треугольник может существовать");
    }
    else 
    {
        Console.WriteLine($"Треугольник не может существовать");
    }
}