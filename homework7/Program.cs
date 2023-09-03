//  Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//  m = 3, n = 4.
//  0,5 7 -2 -0,2
//  1 -3,3 8 -9,9
//  8 7,8 -7,1 9

/*

double [,] CreadRandom2dArray ()                              
{
    
Console.Write("Enter the string: ");
int rows = Convert.ToInt32 (Console.ReadLine());

Console.Write("Enter a column: ");
int columns = Convert.ToInt32 (Console.ReadLine());

Console.Write("Enter min number: ");
double min = Convert.ToDouble (Console.ReadLine());

Console.Write("Enter the maximum number: ");
double max = Convert.ToDouble (Console.ReadLine());


double [,] array = new double [ rows,columns ];

Random random = new Random();

    for ( int i = 0; i < rows; i++) 
        for ( int j = 0; j < columns; j ++)   
        {
            array[i, j] = Math.Round (min + (max - min) * random.NextDouble(),2);    
        }                                                                                               
    return array;    
}                        



void Show2dArray (double [,] array )                               
{
    for ( int i = 0; i < array.GetLength(0); i++ )
    {
        for( int j = 0; j < array.GetLength(1); j++ )  
            Console.Write(array [i,j] + " ");

        Console.WriteLine();
    }
}



double [,] myArray = CreadRandom2dArray ();
Show2dArray( myArray);

*/

//  Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//  Например, задан массив:
//    1 4 7 2
//    5 9 2 3
//    8 4 2 4
//    17 -> такого числа в массиве нет

/*

int [,] CreadRandom2dArray (int rows, int columns, int minValue, int maxValue )
{
    int [,] array = new int [ rows,columns ];

    for ( int i = 0; i < rows; i++) 
        for ( int j = 0; j < columns; j ++)   
            array [i,j] = new Random().Next (minValue, maxValue + 1);

    return array;    
}                        


void Show2dArray (int [,] array )
{
    for ( int i = 0; i < array.GetLength(0); i++ )
    {
        for( int j = 0; j < array.GetLength(1); j++ )  
            Console.Write(array [i,j] + " ");

        Console.WriteLine();
    }
}


void ElementPositions (int[,] array, int row, int column)
{
    int rowCount = array.GetLength(0);
    int columnCount= array.GetLength(1);

    if (row >= 0 && row <= rowCount && column >= 0 && column <= columnCount)
    {
        int value = array[row, column];
        Console.WriteLine($"Element value [{row},{column}]: {value}");
    }
    else
    {
        Console.WriteLine($"Index element[{row},{column}] not ");
    }
}


Console.Write("Enter the string: ");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.Write("Enter a column: ");
int columns = Convert.ToInt32 (Console.ReadLine());
Console.Write("Enter min number: ");
int min = Convert.ToInt32 (Console.ReadLine());
Console.Write("Enter the maximum number: ");
int max = Convert.ToInt32 (Console.ReadLine());

int [,] myArray = CreadRandom2dArray (rows, columns, min, max);

Show2dArray(myArray);

Console.Write("Enter the index of the row: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the index of the column: ");
int column = Convert.ToInt32(Console.ReadLine());

ElementPositions(myArray, row, column);

*/


//    Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//    Например, задан массив:
//    1 4 7 2
//    5 9 2 3
//    8 4 2 4
//    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*


int [,] CreadRandom2dArray ()
{
    Console.Write("Enter the rows: ");
    int rows = Convert.ToInt32 (Console.ReadLine());

    Console.Write("Enter a column: ");
    int columns = Convert.ToInt32 (Console.ReadLine());

    Console.Write("Enter min number: ");
    int min = Convert.ToInt32 (Console.ReadLine());

    Console.Write("Enter max number: ");
    int max = Convert.ToInt32 (Console.ReadLine());

    int [,] array = new int [ rows,columns ];

    for ( int i = 0; i < rows; i++) 
        for ( int j = 0; j < columns; j ++)   
            array [i,j] = new Random().Next (min, max + 1);

    return array;    
}                        

void Show2dArray (int [,] array )
{
    for ( int i = 0; i < array.GetLength(0); i++ )
    {
        for( int j = 0; j < array.GetLength(1); j++ )  
            Console.Write(array [i,j] + " ");

        Console.WriteLine();
    }
}

void ColumnAverage (int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    double[] columnAverages = new double[cols];
    for (int i = 0; i < cols; i++)
    {
        int sum = 0;

        for (int j = 0; j < rows; j++)
        {
            sum += array[j, i];
        }
        columnAverages[i] = (double)sum / rows;
    }
Console.WriteLine();

           for (int k = 0; k < cols; k++)
            Console.WriteLine($"Arithmetic mean in the column {k + 1}: {columnAverages[k]}");
        
}


int [,] myArray = CreadRandom2dArray ();

Show2dArray(myArray);
 
ColumnAverage (myArray);

*/