/* Напишите программу, которая будет преобразовывать десятичное число в двоичное
45 - 101101
3 - 11
2 - 10 */

/*Console.WriteLine($"Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write($"Двоичное число: {GetNumber(a)}");
int GetNumber(int num)
{
while(num>0)
{
    if(num%2 == 0)
    {
        Console.WriteLine($"{0}");
        num = num/2;
    }
    else 
    {
        Console.WriteLine($"{1}");
        num = num/2;
    }
}
return num;
} */


Console.WriteLine($"Введите число: ");
int a = int.Parse(Console.ReadLine()!);
string GetNumber(int num)
{
    int res = 0;
    string number = " ";
    while(num>0)
    {
        res = num%2;
        num = num/2;
        number = res + number;
    }
    return number;
}
Console.Write(GetNumber(a));
