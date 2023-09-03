//  Задача 64: Задайте значение N. Напишите программу, 
//             которая выведет все натуральные числа в промежутке от N до 1. 
//             Выполнить с помощью рекурсии.
//  N = 5 -> "5, 4, 3, 2, 1"
//  N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*

string PrintNumer(int num, string res)
{
    if (num == 1)
    {
        res = res + "" + "1";
        return res;
    }
    else
    {
        res = res + num + " ";
        return PrintNumer(num - 1, res);
    }
}
string result = "";

Console.Write("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());
result = PrintNumer(number, result);
Console.WriteLine(result);

*/



//  Задача 66: Задайте значения M и N. Напишите программу,
//             которая найдёт сумму натуральных элементов в промежутке от M до N.
//  M = 1; N = 15 -> 120
//  M = 4; N = 8. -> 30

/*

int CalculateSum(int min, int max)
{
    if (min == max)

        return min;

    else

        return min + CalculateSum(min + 1, max);
}

Console.Write("Input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write($"Sum of natural elements in the interval from {min} to {max} = {CalculateSum(min, max)} ");

*/



//  Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//             Даны два неотрицательных числа m и n.
//  m = 2, n = 3 -> A(m,n) = 9
//  m = 3, n = 2 -> A(m,n) = 29

/*

int Ackerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Ackerman(m - 1, 1);
    else if (m > 0 && n > 0)
        return Ackerman(m - 1, Ackerman(m, n - 1));
    else
        throw new ArgumentException("Inadmissible arguments of the Ackerman function.");
}

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = Ackerman(m, n);
Console.WriteLine($"Numbers {m} and {n} in the Ackermann function = {result}");

*/