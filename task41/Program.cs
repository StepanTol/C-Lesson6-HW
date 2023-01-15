// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.Write("Введите количество элементов массива:/t ");
int NumCount = int.Parse(Console.ReadLine()!);

//nt GetPositCount (int numCount)
//{
    int[] res = new int[NumCount];
    for(int i = 0; i<NumCount; i++)
    {
        Console.Write($"Введите элемент массива под индексом{i}:/t ");
        res[i] = int.Parse(Console.ReadLine()!);
    }
    //return res;
//}
Console.WriteLine($"Вывод массива: ");
for(int i = 0; i<NumCount; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadLine();