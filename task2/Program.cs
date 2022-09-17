// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int sumDigits(int N)
{
    int result = N % 10;
    N = N / 10;
    while (N != 0)
    {
        result = result + N % 10;
        N = N / 10;
    }
    return result;

}

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {N} равна {sumDigits(N)}");
