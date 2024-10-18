Console.WriteLine("Введите начало отрезка a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите конец отрезка b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите длину шага h: ");
double h = Convert.ToDouble(Console.ReadLine());

if (h <= 0)
{
    Console.WriteLine("Введено некорректное значение h");
    return;
}

int count = (int)((b - a) / h) + 1;
double[] yValues = new double[count];

double max = double.MinValue;
double min = double.MaxValue;

for (int i = 0; i < count; i++)
{
    double x = a + i * h;
    double y = Math.Cos(Math.Pow(x, 2)) + Math.Pow(Math.Sin(x), 2);
    yValues[i] = y; 
    Console.WriteLine($"{y:F2}");

    
    if (y > max) max = y;
    if (y < min) min = y;
}

int signChanges = 0;
for (int i = 1; i < yValues.Length; i++)
{
    if ((yValues[i] > 0 && yValues[i - 1] < 0) || (yValues[i] < 0 && yValues[i - 1] > 0))
    {
        signChanges++;
    }
}

Console.WriteLine($"Количество точек: {yValues.Length}");
Console.WriteLine($"Максимальное значение функции: {max:F2}");
Console.WriteLine($"Минимальное значение функции: {min:F2}");
Console.WriteLine($"Количество раз, сколько функция меняет знак: {signChanges}");

Console.ReadKey();