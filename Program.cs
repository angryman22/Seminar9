// Рекурсия
// n! = 1....n => 1*2*3*4

// int Factorial(int n)
// {
//     //Базовый случай - случай выхода из рекурсии
//     if(n == 1) return 1; // Константа
//     // Рекурсивный случай - задание самой рекурсии (вызова функции)
//     return n * Factorial(n - 1);
// }
// Console.WriteLine(Factorial(4));

// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// int N = Convert.ToInt32(Console.ReadLine());
// string PrintNumber (int start, int end)
// {
//     // Базовый случай
//     if (start == end) return start.ToString();
//     // Рекурсивный случай
//     return (start + ", " + PrintNumber(start + 1, end));
// }
// Console.WriteLine($"Числа от 1 до {N}: {PrintNumber(1, N)}");

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// int M = Convert.ToInt32(Console.ReadLine());
// int N = Convert.ToInt32(Console.ReadLine());
// string PrintNumber (int start, int end)
// {
//     // Базовый случай
//     if (start == end) return start.ToString();
//     // Рекурсивный случай
//     return (start + ", " + PrintNumber(start + 1, end));
// }
// Console.WriteLine($"Числа от {M} до {N}: {PrintNumber(M, N)}");

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int number = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int num)
// {
//     // Базовый случай
//     if (num == 0) return 0;
//     // Рекурсивный случай
//     return (num % 10 + SumNumbers(num / 10));
// }
// Console.WriteLine($"Сумма цифр числа {number} равна {SumNumbers(number)} ");

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int number = Convert.ToInt32(Console.ReadLine());
// int degree = Convert.ToInt32(Console.ReadLine());

// int Power( int number, int power)
// {
//     if ( power == 0) return 1;
//     if ( power == 1) return number;
//     return (number * Power(number, power - 1));
// }
// Console.WriteLine($"Число {number} в степени {degree} равно {Power(number, degree)}");

// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
string PrintNumber (int start, int end)
{
    if (start == end) return start.ToString();
    return (start + ", " + PrintNumber(start + 1, end));
}
Console.WriteLine($"Числа от {M} до {N}: {PrintNumber(M, N)}");

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int numberMin = Convert.ToInt32(Console.ReadLine());
int numberMax = Convert.ToInt32(Console.ReadLine());

int Summ( int min, int max)
{
    if ( min == max) return max;
    return (min + Summ(min + 1, max));
}
Console.WriteLine($"Сумма чисел от {numberMin} до {numberMax} равна {Summ(numberMin, numberMax)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
int Akerman (int m, int n)
{
    if (m == 0) return n + 1;
    else if ( n == 0 && m > 0) return Akerman(m - 1, 1);
    else return Akerman(m - 1, Akerman(m, n - 1));
}
Console.WriteLine($"Значение функции Акермана при m = {m} и n = {n} равно {Akerman(m,n)}");
