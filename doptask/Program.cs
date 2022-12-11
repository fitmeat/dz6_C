double FindArea(double x1, double y1, double x2, double y2, double x3, double y3)
{
    return Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1)) / 2;
}

Console.Clear();
Console.WriteLine("Введите x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x3: ");
double x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y3: ");
double y3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindArea(x1, y1, x2, y2, x3, y3));