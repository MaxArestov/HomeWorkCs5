//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
Console.WriteLine("Введите цифру, обозначающую количество элементов массива:");
int n = IsDigitMeth();
int[] array = new int[n];
FillArray(array);
PrintArray(array);
int maxValue = FindMaxValue(array);
int minValue = FindMinValue(array);
int dif = (maxValue - minValue);
Console.WriteLine($"MaxValue - {maxValue}");
Console.WriteLine($"MinValue - {minValue}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {dif}");




int IsDigitMeth()
{
    bool checkDigit = true;
    int count = 0;
    while (checkDigit)
    {
        if (!int.TryParse(Console.ReadLine(), out count))
        {
            Console.WriteLine("Введены некорректные данные. Введите целое число.");
        }
        else checkDigit = false;
    }
    return count;
}
void FillArray(int[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(1, 1000);
    }
}
void PrintArray(int[] arr1)
{
    for (int o = 0; o < arr1.Length; o++)
    {
        Console.Write($"{arr1[o]} ");
    }
    Console.WriteLine();
}

int FindMaxValue(int[] arr2)
{
    int max = arr2[0];
    for (int x = 1; x < arr2.Length; x++)
    {
        if (arr2[x] > max)
        {
            max = arr2[x];
        }
    }
    return max;
}
int FindMinValue(int[] arr3)
{
    int min = arr3[0];
    for (int y = 1; y < arr3.Length; y++)
    {
        if (arr3[y] < min)
        {
            min = arr3[y];
        }
    }
    return min;
}