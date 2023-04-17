/*Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
    {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
            Console.Write($"{matr[i, j]} ");
    }
            Console.WriteLine();
    }
}

void FillArray(int[,] matr, int min, int max)
{
for (int i = 0; i < matr.GetLength(0); i++)
    {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i, j] = new Random().Next(min, max+1);
    }
    }
}

double SumElements1(int[,] matr)
{
double sum1 = 0;
for (int i = 0; i < matr.GetLength(0); i++)
    {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
    if (j == 0) sum1 +=matr[i,j];
    }
    }
return sum1;
}

double SumElements2(int[,] matr)
{
double sum2 = 0;
for (int i = 0; i < matr.GetLength(0); i++)
    {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
    if (j == 1) sum2 +=matr[i,j];
    }
    }
return sum2;
}

double SumElements3(int[,] matr)
{
double sum3 = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
    if (j == 2) sum3 +=matr[i,j];
    }
    }
return sum3;
}

double SumElements4(int[,] matr)
{
double sum4 = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
    if (j == 3) sum4 +=matr[i,j];
    }
    }
return sum4;
}

int[,] array = new int[3,4];
FillArray(array,0,9);
PrintArray(array);
System.Console.WriteLine($"Среднее арифметическое 1 столбца = {SumElements1(array)/3}");
System.Console.WriteLine($"Среднее арифметическое 2 столбца = {SumElements2(array)/3}");
System.Console.WriteLine($"Среднее арифметическое 3 столбца = {SumElements3(array)/3}");
System.Console.WriteLine($"Среднее арифметическое 4 столбца = {SumElements4(array)/3}");