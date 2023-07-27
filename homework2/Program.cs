// Task 10 .  Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
 
/*

 int Number (int num)
 {
     //int numOne = num / 10;        
     //int numRes = numOne % 10;       
     // return numRes;
   int numRes = (num / 10) % 10;
   return numRes;
 }

Console.WriteLine("Enter a three-digit number: "); 
int threeDigit = Convert.ToInt32(Console.ReadLine());

if (threeDigit < 100 || threeDigit >= 1000)
{
   Console.WriteLine ("You have entered an incorrect three-digit number, please repeat the entry. "); 
}
else 
 {
 int res = Number(threeDigit);
 Console.Write("Second digit of this number: " + res );
 }

*/

// Task 13.   Задача 13: Напишите программу, которая выводит третью цифру заданного числа ( или -1, если третьей цифры нет.

/*

int Number (int num)
{
   int numRes = (num % 10);
   return numRes;
  // return num < 0 ? -numRes : numRes;      // если " - ", то переводит в " + "
}

Console.WriteLine("Enter a number: ");
int digit = Convert.ToInt32(Console.ReadLine());

if (digit <= 999)
{
   int res = Number (digit);
   Console.WriteLine("Three digit: " + res );
}
if (digit <= 99);
{
   Console.WriteLine("Wrong number '-1' ");
}


*/


// Task 15.   Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*

Console.WriteLine("Enter the number that represents the day of the week (1-7): ");
int dayOfWeekNumber = Convert.ToInt32(Console.ReadLine());

bool isWeekend = dayOfWeekNumber == 6 || dayOfWeekNumber == 7;

Console.WriteLine(isWeekend ? "Day off !" : "Working day !");


*/