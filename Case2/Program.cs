//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
Console.WriteLine("Введите число, обозначающее количество элементов массива:");
int n = IsDigitMeth();
int[] array = new int[n];
FillArray(array);
PrintArray(array);
int sumOfEven = SumEvenPosition(array);
Console.WriteLine($"Сумма всех элементов, стоящих на четных позициях - {sumOfEven}.");






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
        arr[i] = random.Next(-10000, 10001);
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
int SumEvenPosition(int[] arr2)
{
    int sum = 0;
    for (int y = 2; y < arr2.Length; y += 2)
    {
        sum+= arr2[y];
    }
    return sum;
}