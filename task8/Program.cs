Console.WriteLine("Input number");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 0)
{

int i = 1;

while (i <= N)
{
    if (i % 2 == 0)
    {
        Console.WriteLine (i);
    }
i++;
}
}
else
{
    Console.WriteLine("Введите целое положительное число");
}