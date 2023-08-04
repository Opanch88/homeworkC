// Task 19 . Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

/*

Console.WriteLine ("Enter the 5-digit number: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
if (number[0] == number[4] && number [1] == number[3])
{
    Console.WriteLine(number + " Palindrome ");
}

else
{
    Console.WriteLine(number + " Not a palindrome ");
}
}
else
{
    Console.WriteLine ("You did not enter a 5-digit number !");
}


*/



//Task  21.  Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53



/*


double ReadInt(string graphics)
{
    Console.Write(graphics);
    return Convert.ToInt32(Console.ReadLine());
}


double x1 = ReadInt("Enter х1: ");                           // дописать что б работ double 
double y1 = ReadInt("Enter y1: ");
double z1 = ReadInt("Enter z1: ");
double x2 = ReadInt("Enter х2: ");
double y2 = ReadInt("Enter y2: ");
double z2 = ReadInt("Enter z2: ");

double A = x2 - x1;
double B = y2 - y1;
double C = z2 - z1;

double length = Math.Round(Math.Sqrt(A * A + B * B + C * C), 2);
Console.WriteLine("Distance = " + length);


*/




//Task 23 .  Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

/*

int ReadInt(string cube)
{
    Console.Write(cube);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadInt("Enter a number: ");

for (int i = 0; i <= number; i++)
{
    Console.Write($"{i * i * i} ");
}

*/

