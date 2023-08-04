// Task 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*

Console.WriteLine("Enter a number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a number B: ");
int b = Convert.ToInt32(Console.ReadLine());

int degree = a;

for (int i = 1; i < b; i++)
{
    degree = degree * a ;
}

Console.WriteLine("A to the extent of B equally :" + degree );

*/



// Task 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*

Console.WriteLine("Enter a number:");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i != 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num ;
}
Console.WriteLine("The sum of all digits in a number is equal to: " + sum);

*/



// Task 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*

Console.Write("Enter the number of elements of the array: ");
int length = int.Parse(Console.ReadLine());

int[] array = new int[length];

for (int i = 0; i < length; i++)
{
    Console.Write($"Enter an element {i + 1}: ");
     array[i] = int.Parse(Console.ReadLine());
}

Console.Write("Input array: [ ");

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);

    if (i < array.Length )
    {
        Console.Write(", ");
    }
}
Console.WriteLine("]");

*/