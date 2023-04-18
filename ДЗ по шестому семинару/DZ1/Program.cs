// Сколько чисел больше 0 ввёл пользователь.


/*int[] FillArray (int length, int minValue, int maxValue)
{
    int[] result = new int[length];
    Random rand = new Random();
    for(int i = 0; i < length; i++)
    {
        result[i] = rand.Next(minValue, maxValue);
    }
    return result;
}
int GetSum (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum = sum + 1;
        }
    }
    return sum;
}
int[] array = FillArray (100, -100, 100);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(string.Join(", ", GetSum(array)));*/
int[] FillArray (int length)
{
    int[] result = new int[length];
    Console.WriteLine("Введите число элементов массива ");
    length = int.Parse(Console.ReadLine());
    for(int i = 0; i < length; i++)
        {
        Console.WriteLine($"Введите {i+1} число массива ");
        result[i] = int.Parse(Console.ReadLine());
        }
    return result;
}
int GetSum (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum = sum + 1;
        }
    }
    return sum;
}
int[] array = FillArray (10);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(string.Join(", ", GetSum(array)));