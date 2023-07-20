/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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

void DigitMatch(int[,] array, int digit)
{
    int size1, size2, flag=0;
    size1 = array.GetLength(0);
    size2 = array.GetLength(1);
    for (int i = 0; i < size1; i++)
    {
         for (int j = 0; j < size2; j++)
        {
            if (digit == array[i,j])
            {
                Console.WriteLine($"{digit} найдено на позиции [{i+1} , {j+1}]");
                flag=1;
            }
        }
    }
    if (flag==0)
        Console.WriteLine("Число не найдено");
}

int m=3;
int n=4;
int digit;
Console.Write("Введите число для поиска: ");
digit=int.Parse(Console.ReadLine());
int [,]array= new int[m,n];
array=ArrayFill(array);
ShowArray(array);
DigitMatch(array,digit);