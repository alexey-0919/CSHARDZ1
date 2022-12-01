Console.WriteLine("Введите первое число");
int NumberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int NumberTwo = Convert.ToInt32(Console.ReadLine());

if (NumberOne > NumberTwo)
{
    int max = NumberOne;
    int min = NumberTwo;
    Console.WriteLine ("Максимум " + max);
    Console.WriteLine ("Минимум " + min );
}
else
{
    int max = NumberTwo;
    int min = NumberOne;
    Console.WriteLine ("Максимум " + max);
    Console.WriteLine ("Минимум " + min);
}