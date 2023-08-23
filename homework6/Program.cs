// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*

Console.Write("Enter the number of elements of the array: ");

int elements = Convert.ToInt32(Console.ReadLine());

    int [] array = new int [elements];  

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Enter the array element at index {i}: ");
        array [i] = Convert.ToInt32(Console.ReadLine());
    }


void WriteArray (int[]array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i] + " ");

    Console.WriteLine();
}


int CountNumber ( int[]array )
{
int count = 0; 

for (int i = 0; i < array.Length; i++) 
{  
    if (array [i] > 0 )
        count++;
}
    return count;
}



Console.WriteLine($"Array: ");
WriteArray(array);
Console.WriteLine();
Console.WriteLine($"Entering numbers greater than zero: {CountNumber(array)} ");

*/







// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*

Console.WriteLine("Enter the values k1, b1, k2 и b2 for the equations y = k1 * x + b1 и y = k2 * x + b2:");

Console.Write("k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine("The lines are parallel and do not intersect.");
}
    else
{

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Intersection point: ({x}, {y})");
}

*/


// Additional task. Напишите программу, преобразующую число из дяситичной системы счисления в двоичную.

/*

string NumberConver(int decimalNumber)
{
    if (decimalNumber == 0)
    return "0";

string binary = " ";
while (decimalNumber > 0)
{
    int remainder = decimalNumber % 2;
    binary = remainder + binary;
    decimalNumber = decimalNumber / 2;
}
    return binary;
 }


Console.Write("Enter a decimal number: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());

string number = NumberConver(decimalNumber);

Console.WriteLine($"Binary representation of a number: {number}");

*/