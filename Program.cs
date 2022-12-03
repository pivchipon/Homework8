/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

/*int A = 0;
Console.WriteLine("Enter the number of rows :");
A = Convert.ToInt32(Console.ReadLine());

int B = 0;
Console.WriteLine("Enter the number of columns :");
B = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[A, B];
FillArray(array);
PrintArray(array);

int MinSum = 0;
int Sum = SumElements(array, 0);

for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumElements(array, i);
  if (Sum > tempSumLine)
  {
    Sum = tempSumLine;
    MinSum = i;
  }
}

Console.WriteLine($"Row with a smallest sum of numbers {MinSum + 1} ");


int SumElements(int[,] array, int i)
{
  int Sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    Sum += array[i,j];
  }
  return Sum;
}


void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0,10);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}*/




/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

/*int [,] array1 = new int [2,2];

for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(0); j++)
    {
        array1 [i, j] = new Random().Next(0,12);
        Console.Write(array1[i, j] + " ");
    }
     Console.WriteLine();
}

Console.WriteLine("__");
Console.WriteLine();

int [,] array2 = new int [2,2];

for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(0); j++)
    {
        array2 [i, j] = new Random().Next(0,12);
        Console.Write(array2[i, j] + " ");
    }
     Console.WriteLine();
}

Console.WriteLine("__");
Console.WriteLine();

int [,] array3 = new int [2,2];

for (int i = 0; i < array3.GetLength(0); i++)
{
    for (int j = 0; j < array3.GetLength(0); j++)
    {
        int Sum = 0;
        for (int k = 0; k < array3.GetLength(0); k++)
        {
            Sum += array1[i, j] * array2 [k, j];
        }
        Console.Write((array3[i, j] = Sum) + " ");
    }
    Console.WriteLine();
}*/


/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

/*int A = 0;
System.Console.WriteLine("Enter the number of array's element: ");
A = Convert.ToInt32(Console.ReadLine());
int[,] SquareMatrix = new int[4, 4];

int X = 1;
int i = 0;
int j = 0;

while (X <= SquareMatrix.GetLength(0) * SquareMatrix.GetLength(1))
{
    SquareMatrix[i, j] = X;
    X++;
    if (i <= j + 1 && i + j < SquareMatrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= SquareMatrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > SquareMatrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

WriteArray(SquareMatrix);

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}*/



/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int A = 0;
System.Console.WriteLine("Enter the number of array's element: ");
A = Convert.ToInt32(Console.ReadLine());
int[,] SquareMatrix = new int[4, 4];

int X = 1;
int i = 0;
int j = 0;

while (X <= SquareMatrix.GetLength(0) * SquareMatrix.GetLength(1))
{
    SquareMatrix[i, j] = X;
    X++;
    if (i <= j + 1 || i + j < SquareMatrix.GetLength(1) - 1)
        j++;
    if (i < j || i + j >= SquareMatrix.GetLength(0) - 1)
        i++;
    else if (i >= j || i + j > SquareMatrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

WriteArray(SquareMatrix);

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}