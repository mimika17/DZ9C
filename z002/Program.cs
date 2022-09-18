// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int Summa(int M, int N)
{
    if (N == M - 1) return 0;
    return N + Summa(M, N - 1);
}
try
{
    Console.WriteLine("Введите значение M");
    Console.Write("M=");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение N");
    Console.Write("N=");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} = {Summa(m, n)}");
}
catch
{
    Console.WriteLine("Введите натуральное число!!!");
}
