/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int [,] ArrayFill(int[,] array)
{
    int size1, size2;
    size1 = array.GetLength(0);
    size2 = array.GetLength(1);
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
            array[i,j] = new Random().Next(10);
    }
    return array;
}

void ShowArray(int[,] array)
{
    int size1, size2;
    size1 = array.GetLength(0);
    size2 = array.GetLength(1);
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        Console.Write($" {array[i,j]} ");
        Console.WriteLine();
    }
}

void MiddleArifmetic(int[,] array)
{
    int size1, size2, i;
    double arifmetic, line=0;
    size1 = array.GetLength(0);
    size2 = array.GetLength(1);
    for (int j = 0; j < size2; j++)
    {
        arifmetic=0;
        line=0;
        for (i = 0; i < size1; i++)
            line=line+array[i,j];
        arifmetic=Math.Round(line/size1,1);
        Console.WriteLine($"Среднее арифметическое {j+1} столбца равно {arifmetic}");
    }
}

int m=3;
int n=4;
int [,]array= new int[m,n];
array=ArrayFill(array);
ShowArray(array);
MiddleArifmetic(array);