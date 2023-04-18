/*Задача 50. Напишите программу, которая на вход принимает элемент 
в двумерном массиве, и возвращает его индексы первого найденого числа 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

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

int[,] array = new int[3,4];
FillArray(array,0,9);
PrintArray(array);


int numRows = ReadInt("Введите индекс строки: ");
int numColums = ReadInt("Введите индекс столбца: ");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

if (numRows < array.GetLength(0) && numColums < array.GetLength(1))
{
    Console.WriteLine($"Число равно = {array[numRows,numColums]}");
}
else
{
    Console.WriteLine("Числа в массиве нет");
}