/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double [,] ArrayFill(double[,] array)
{
    int size1, size2, pos;
    size1 = array.GetLength(0);
    size2 = array.GetLength(1);
    for (int i = 0; i < size1; i++)
    {
         for (int j = 0; j < size2; j++)
         {
            pos = new Random().Next(2);
            if (pos==0)
                pos=-1;
            array[i,j] = new Random().Next(1, 100)/10.00*pos;
            Console.Write($"{array[i,j]}, ");
         }
         Console.WriteLine();
    }
    return array;
}

int m=3;
int n=4;
double [,]array= new double[m,n];
array=ArrayFill(array);