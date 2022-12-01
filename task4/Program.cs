Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
{
    int max = a;
    Console.WriteLine("Максимум " + a);
}
if (b > a && b > c)
    {
        int max = b;
        Console.WriteLine("Максимум " + b);
    }
if (c > a && c > b)
    {
        int max = c;
        Console.WriteLine("Максимум " + c);
    }

