// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int m = ReadInt("Введите начальное число: ");
int n = ReadInt("Введите конечное число: ");
int SumNumbers(int m, int n)
{

    if (m == 0)
    { return n + 1; }                                                   // Если m равно нулю
    else if (n == 0 && m > 0) { return (SumNumbers(m - 1, 1)); }                    // Если m >0 ,n=0
    else if (m > 0 && n > 0) { return SumNumbers(m - 1, SumNumbers(m, n - 1)); }    // Если m > 0 ,n>0 
    return SumNumbers(m, n);
}
System.Console.WriteLine($"Функция Аккермана = {SumNumbers(m,n)}");
