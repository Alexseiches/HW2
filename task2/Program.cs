Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine()!);
int number = A;
if (A < 100)
{
    Console.WriteLine("Не имеет третьей цифры");
}
int ThirdNumber(int number)
{
    while (number >999)
    {
        number /= 10;
    }
}
bool NonNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
}
int number = Console.ReadLine("Введите число");
if (NonNumber(number))
{
    Console.WriteLine(ThirdNumber(number));
}