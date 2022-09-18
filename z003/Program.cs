// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
int AckermannFunction(int M, int N)
{
    if (M == 0) return N + 1;
    else if (M > 0 && N == 0) return AckermannFunction(M - 1, 1);
    else if (M > 0 && N > 0) return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
    return AckermannFunction(M, N);
}
try
{
    Console.WriteLine("Введите значение M");
    Console.Write("M=");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение N");
    Console.Write("N=");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {AckermannFunction(m, n)}");
}
catch
{
    Console.WriteLine("Введите натуральное число!!!");
}