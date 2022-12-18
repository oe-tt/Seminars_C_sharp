Console.WriteLine("Введите три числа!");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int max = a;
if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}

Console.Write("max = ");
Console.WriteLine(max);
