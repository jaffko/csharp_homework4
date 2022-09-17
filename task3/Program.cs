//  Напишите программу, которая задаёт массив из N элементов и выводит их на экран. N - вводится с клавиатуры. Элементы тоже вводятся с клавиатуры.
// 5
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 3
// 6, 1, 33 -> [6, 1, 33]

int[] newArray(int N)
{
    int[] result = new int[N];
    for (int i = 0; i < N; i++) result[i] = Convert.ToInt32(Console.ReadLine());
    return result;
}

Console.WriteLine("Введите размер массива N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(string.Join(", ", newArray(N)));
