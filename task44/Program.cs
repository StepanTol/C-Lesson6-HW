// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. 
// Если N = 5, то 0 1 1 2 3 
// Если N = 3, то 0 1 1  
// Если N = 7, то 0 1 1 2 3 5 8 

Console.WriteLine($"Введите число: ");
int N = int.Parse(Console.ReadLine()!);
GetFibonachi(N);

void GetFibonachi(int num)
{
    int[] res = new int[num];
    res[0] = 0;
    res[1] = 1;
   Console.Write(res[0] + " " + res[1] + " ");
    for(int i = 2; i<num; i++)
    {
        res[i] = res[i-2] + res[i-1];    
        Console.Write(res[i] + " ");    
    }
}


/*Console.WriteLine($"Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int[] GetFibonachi(int num)
{
    int[] res = new int[num];
    res[0] = 0;
    res[1] = 1;
    for(int i = 2; i<num; i++)
    {
        res[i] = res[i-2] + res[i-1];    
    }    
    return res;
}
int[] GetFib = GetFibonachi(N);
Console.WriteLine(string.Join(" ",GetFib));*/