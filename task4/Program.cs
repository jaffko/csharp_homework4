// Напишите программу, которая принимает на вход число (целое или вещественное) и выдаёт количество цифр в числе.
// 456 -> 3
// 0.78 -> 2
// 89.126 -> 5

int digitsNum(double N)
{
    while (N % 1 !=0) N = N * 10;
    int numLen = 1;
    int i = 10;
    while (N % i != N)
    {
        numLen++;
        i = i * 10;
    }
    return numLen;
}

Console.WriteLine("Введите число:");
double num = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе {num} равно {digitsNum(num)}");
