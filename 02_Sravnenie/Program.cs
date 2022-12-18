Console.WriteLine("ведите два числа!");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.Write ("max = ");
    Console.WriteLine (a);
}
else
{
    if (a < b)
    {
        Console.Write ("max = ");
        Console.WriteLine (b);
    }
    else
    {
        Console.WriteLine ("Числы равны!");
    }
}