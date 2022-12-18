Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int b = 2;
if (a < 2)
{
    Console.WriteLine("Введенное число слишком мало!");
}
while (b <= a)
{
    Console.Write(b);

    if ((b < a) & (b + 1 < a))
    {
        Console.Write(", ");
    }
    else
    {
        Console.Write(".");
    }
    b += 2;
}