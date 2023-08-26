// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double [,] matrix = new double [3,4];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().NextDouble()*10;
//         Console.Write(matrix[i,j]+" ");
//     }
//     Console.WriteLine();
// }



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите номер строки");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int [,] matrix = new int [3, 4];

// void FillArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 matrix[i,j]= new Random().Next(0,10);
//                 Console.Write(matrix[i,j]+" ");
//             }
//         Console.WriteLine();
//     }
// }
// FillArray(matrix);
// Console.WriteLine();

// if(num1>=0 && num1<3 && num2>=0 && num2<4)
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(i==num1 && j==num2)
//             {
//                 Console.WriteLine(matrix[i,j]);
//             }  
//     }
// }
// else
//     {
//         Console.WriteLine("Такого элемента нет");
        
//     }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите первую размерность");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую размерность");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [rows,columns];

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i,j]= new Random().Next(0,10);
                Console.Write(matrix[i,j]+" ");
            }
        Console.WriteLine();
    }
}
FillArray(matrix);
Console.WriteLine();

int sum=0;
double average=0;

for (int j = 0; j < matrix.GetLength(1); j++)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum+=matrix[i,j];
    }
average=(double)sum/rows;
Console.WriteLine("Среднее арифметическое = "+average);
sum=0;
}
      