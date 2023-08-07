    // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    // [345, 897, 568, 234] -> 2.

/*

int [] CreateRandomArray(int size)
{
    int [] array = new int [size];  

    for (int i = 0; i < size; i++) 
        array [i] = new Random().Next (100, 1000);
    return array;
}

void WriteArray (int[]array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}


Console.Write("Input a Length of array: ");
int m = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandomArray(m);
Console.Write("Our array: ");
WriteArray(myArray);


int num = 0;

for (int i = 0; i < myArray.Length; i++)
if (myArray[i] % 2 == 0)

num++;

Console.WriteLine ("Number of even numbers: " + num );


*/



    // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    // [3, 7, 23, 12] -> 19
    // [-4, -6, 89, 6] -> 0

/*

int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] array = new int [size];  

    for (int i = 0; i < size; i++) 
        array [i] = new Random().Next (minValue, maxValue);
    return array;
}

void WriteArray (int[]array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}



int SumOf(int[] array)
{
    int sum  = 0;

    for (int i = 0; i < array.Length; i+=2)
            sum += array[i];
    return sum;    
}


Console.Write("Input a Length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(m, a, b);
Console.Write("Our array: ");
WriteArray(myArray);


Console.WriteLine("The sum of elements on odd positions: " + SumOf(myArray)); 

*/







    // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    // [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

/*

double [] CreateRandomArray(int size)
{
    double [] array = new double [size];  

    for (int i = 0; i < size; i++) 
        array [i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    return array;
}

void WriteArray (double[]array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " | ");

    Console.WriteLine();
}




Console.Write("Input a Length of array: ");
int m = Convert.ToInt32(Console.ReadLine());


double [] myArray = CreateRandomArray(m);
Console.Write("Our array: ");
WriteArray(myArray);




double min = myArray [0];
double max = myArray [0];

for (int i = 1; i < myArray.Length; i++)  

{
    if (myArray[i] > max)
{
    max = myArray[i];
}

    if (myArray[i] < min)
{
    min = myArray[i];
}
}

Console.WriteLine("Maximum value: " + ( max ) );
Console.WriteLine("Minimum value: " + ( min ) );
Console.WriteLine("Value difference: " + ( max - min ) );

*/
