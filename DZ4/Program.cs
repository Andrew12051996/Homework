// Вывод четных элементов
Console.WriteLine("Enter number: ");
string FirstNum = Console.ReadLine();
int Num = Convert.ToInt32(FirstNum);
for (int i = 1; i <= Num; i++)
    {
        if (i % 2 == 0) 
        {
        Console.WriteLine(i);
        }
        
    }