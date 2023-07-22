// Task 2 . Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*

Console.Write ("Input a frist number: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input a second number: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB)
{
    Console.WriteLine("MaxNumber: " + numA);
    Console.WriteLine("MinNumber: " + numB);
}
else 
{
    Console.WriteLine("MaxNumber: " + numB);
    Console.WriteLine("MinNumber: " + numA);
}

*/



// Task 4. Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*

Console.Write ("Input a frist number : ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input a second number : ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input a third number : ");
int numC = Convert.ToInt32(Console.ReadLine());

int maxNumber = numA;

    if (numB > maxNumber)
            maxNumber = numB;

    if (numC > maxNumber)
            maxNumber = numC;

Console.WriteLine("MaxNumber: " + maxNumber);

*/



// Task 6. Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*

Console.Write ("Enter a number : ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine ("even number " + num );
}
else 
{
    Console.WriteLine ("odd number");
}

*/



// Task 8. Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*

Console.Write ("Enter a number : ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("even numbers : "); 

for (int i = 1; i <= num; i++)
{
if (i % 2 == 0)

Console.Write(i + " ");
}

*/