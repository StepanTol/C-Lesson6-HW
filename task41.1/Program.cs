// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Write("Введите количество элементов массива: ");
int NumCount = int.Parse(Console.ReadLine()!);
GetPositCount(NumCount);

void GetPositCount (int num)
{
    int[] res = new int[num];
    for(int i = 0; i<num; i++)
    {
        Console.Write($"Введите элемент массива под индексом{i}: ");
        res[i] = int.Parse(Console.ReadLine()!);
    }
    for(int i = 0; i<num; i++)
    {
        Console.WriteLine($"{res[i]}");
    }
    int count = 0;
    for(int i = 0; i<num; i++)
    {
    if(res[i]>0)
    {
        count++;
    }
    }
    Console.WriteLine($"Количество положительных чисел: {count} ");    
}

