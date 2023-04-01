Console.WriteLine("Введите трехзначное число");
int A = int.Parse(Console.ReadLine()!);
int number = A ;
if ( number < 100 || number >= 1000 );
{
    Console.WriteLine("Вы ввели не трехзначное число!");
}
Console.WriteLine($"Введенное число {number}");
int SecondNumber = number / 10 % 10;
Console.WriteLine($"Вторая цифра {SecondNumber}");