//  Task 54: Задайте двумерный массив. Напишите программу,
//           которая упорядочит по убыванию элементы каждой строки двумерного массива.


/*
int[,] CreadRandom2dArray()
{
    Console.Write("Enter the string: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter a column: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter min number: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the maximum number: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

void SortLine(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])                           // " < - по убыванию  "
                {                                                      // " > - по возрастанию "
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }

        }
    }
}

int[,] myArray = CreadRandom2dArray();
Console.WriteLine("Array: ");
Show2dArray(myArray);
Console.WriteLine();
Console.WriteLine("Sorted array in descending order: ");
SortLine(myArray);
Show2dArray(myArray);
*/



//  Task 56: Задайте прямоугольный двумерный массив. Напишите программу,
//           которая будет находить строку с наименьшей суммой элементов.


/*
int[,] CreadRandom2dArray()
{

    Console.Write("Enter the string: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter a column: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the minimum number: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the maximum number: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

int[] SumMinRows(int[,] array)
{
    int[] result = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        result[i] = sum;
    }
    return result;
}

int SumMinNumbers(int[] array)
{
    int length = array.Length;
    int index = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] < array[index]) index = i;
    }
    return index + 1;
}

int[,] myArray = CreadRandom2dArray();
Console.WriteLine();
Show2dArray(myArray);

Console.WriteLine();

Console.WriteLine($"Row with the lowest sum of elements: {SumMinNumbers(SumMinRows(myArray))}");
*/



//    Task 58: Задайте две матрицы. Напишите программу, 
//             которая будет находить произведение двух матриц.

/*

int[,] CreateRandomMatrixA()
{
    Console.Write("Enter the number of rows of the first matrix: ");
    int rowsA = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the number of columns of the first matrix: ");
    int columnsA = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rowsA, columnsA];
    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < columnsA; j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
    return array;
}

int[,] CreateRandomMatrixB()
{
    Console.Write("Enter the number of rows of the second matrix: ");
    int rowsB = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the number of columns of the second matrix: ");
    int columnsB = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rowsB, columnsB];
    for (int n = 0; n < rowsB; n++)
    {
        for (int k = 0; k < columnsB; k++)
        {
            array[n, k] = new Random().Next(1, 100);
        }
    }
    return array;

}

void ShowMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] MatrixA, int[,] MatrixB)
{
    int rowsA = MatrixA.GetLength(0);
    int colsA = MatrixA.GetLength(1);
    int rowsB = MatrixB.GetLength(0);
    int colsB = MatrixB.GetLength(1);

    if (colsA != rowsB)
    {
        throw new ArgumentException("Количество столбцов первой матрицы должно совпадать с количеством строк второй матрицы.");
    }

    int[,] result = new int[rowsA, colsB];

    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < colsB; j++)
        {
            int sum = 0;
            for (int k = 0; k < colsA; k++)
            {
                sum += MatrixA[i, k] * MatrixB[k, j];
            }
            result[i, j] = sum;
        }
    }

    return result;
}

int[,] MatrixA = CreateRandomMatrixA();
int[,] MatrixB = CreateRandomMatrixB();

Console.WriteLine("");

Console.WriteLine("First matrix:\n");
ShowMatrix(MatrixA);

Console.WriteLine("");

Console.WriteLine("Second matrix:\n");
ShowMatrix(MatrixB);

Console.WriteLine("");

Console.WriteLine("Matrix sum:\n");
ShowMatrix(MatrixMultiplication(MatrixA, MatrixB));

*/

//    Task 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//               Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


/*
int[,,] CreateRandom3dArray()
{

    Console.Write("Enter the string: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter a column: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter a depth : ");
    int depth = Convert.ToInt32(Console.ReadLine());

    int number = 0;
    int[,,] array = new int[rows, columns, depth];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int k = 0; k < depth; k++)
            {
                number = new Random().Next(10, 100);
                if (NumberInArray(array, number))
                {
                    k--;
                    continue;
                }
                else
                    array[i, j, k] = number;
            }
    return array;
}

bool NumberInArray(int[,,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                if (num == array[i, j, k])
                    return true;
    return false;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) \t");
            }
        }
    }
    Console.WriteLine();
}

int[,,] myArray = CreateRandom3dArray();

Show3dArray(myArray);
*/


//    Task 62. Напишите программу, которая заполнит спирально массив 4 на 4.


/*
int[,] array = new int[4, 4];
int value = 1;
int minRow = 0, minCol = 0;
int maxRow = 3, maxCol = 3;

while (value < array.Length)
{

    for (int i = minCol; i <= maxCol; i++)
    {
        array[minRow, i] = value++;
    }
    minRow++;

    for (int i = minRow; i <= maxRow; i++)
    {
        array[i, maxCol] = value++;
    }
    maxCol--;

    for (int i = maxCol; i >= minCol; i--)
    {
        array[maxRow, i] = value++;
    }
    maxRow--;

    for (int i = maxRow; i >= minRow; i--)
    {
        array[i, minCol] = value++;
    }
    minCol++;
}

void PrintSpiralArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j] + " ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
PrintSpiralArray(array);
*/
