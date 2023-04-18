// Точка пересечения.
Console.WriteLine("Введите координату k1 первой точки ");
double k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату b1 первой точки ");
double b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату k2 второй точки ");
double k2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату b2 первой точки ");
double b2 = int.Parse(Console.ReadLine());
double X = (b2 - b1) / (k2 - k1);
double Y = (k1 * X + b1) - (k2 * X - b2);
if((k1 * X + b1) == (k2 * X + b2))
{
    Console.WriteLine("Прямые параллельны");
}
else {
   
    Console.WriteLine($"Точка пеересечения {X}, {Y}");
}