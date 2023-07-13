// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Numbers(int M, int N)
{
    if (M > N) return;
    System.Console.Write(M + " ");
    Numbers(M + 1, N);

}

int M = ReadInt("Введите начальное число: ");
int N = ReadInt("Введите конечное число: ");
if (M <= N)
{
    Numbers(M, N);
}
else
{
    Numbers(N, M);
}

System.Console.WriteLine();
void Printsum(int M, int N, int sum)
{
    if (M > N)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке : {sum}");
        return;
    }
    sum = sum + (M++);
    Printsum(M, N, sum);
}
Printsum(M, N, 0);










