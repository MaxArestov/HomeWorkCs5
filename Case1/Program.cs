/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/
Console.Clear();
Console.WriteLine("Введите число, означающее количество элементов массива:");
int n = IsDigitMeth();
int[] array = new int[n];
FillArray(array);
PrintArray(array);
int countEven = HowManyEvenDigits(array);
Console.WriteLine($"Количество четных чисел в массиве = {countEven}.");







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
    Random random= new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(100, 1000);
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
int HowManyEvenDigits(int[] arr2)
{
    int countEven = 0;
    for (int z = 0; z < arr2.Length; z++)
    {
        if (arr2[z] % 2 == 0)
        {
            countEven++;
        }
    }
    return countEven;
}