 /*Задайте значение N. Напишите программу, которая выведет все натуральные числа 
 в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

/*Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(visionnumbers(N, 1));


string visionnumbers(int start, int end)
{
    if(start == end) return start.ToString();
    return (start + " " + visionnumbers(start - 1, end));
}*/



/*Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

/*Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна {(SumNumbers(m, n))}");

int SumNumbers(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        if (m < n)
        {
            return m + SumNumbers(m + 1, n);
        }
        else
        {
            return m + SumNumbers(m - 1, n);
        }
    }
}*/



/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

/*Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Результат вычисления функции Аккермана: {(AckermannFunction(m, n))}");

int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (m > 0 && n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}*/