//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*
double [,] CreateRandom2DArray ()
{
    Console.WriteLine("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    double [,] array = new double[rows, columns];
    
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue+1);
            double num = new Random().NextDouble();
            array[i,j] = array[i,j] + num;
            array[i,j] = Math.Round(array[i,j],3);           
        }
        
    return array;
}

void Show2DArray (double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i,j] + " ");
            }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double [,] newArray = CreateRandom2DArray();
Show2DArray(newArray);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int [,] CreateRandom2DArray ()
{
    Console.WriteLine("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int [,] array = new int[rows, columns];
    
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue+1);
        
    return array;
}

void Show2DArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void IsIndexBelongArray (int [,] array, int indexI, int indexJ)
{
    if (indexI <= array.GetLength(0) && indexJ <= array.GetLength(1))
    {
        int number = array[indexI,indexJ];
        Console.WriteLine($"Число {number} с индексом ({indexI},{indexJ}) принадлежит массиву");
    }
    else Console.WriteLine("Число с таким индексом не принадлежит массиву");
}

Console.WriteLine("Введите номер строки: ");
int indexI = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int indexJ = Convert.ToInt32(Console.ReadLine());

int [,] newArray = CreateRandom2DArray();
Show2DArray(newArray);

IsIndexBelongArray(newArray, indexI, indexJ);
*/

//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
/*
int [,] CreateRandom2DArray ()
{
    Console.WriteLine("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int [,] array = new int[rows, columns];
    
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue+1);
        
    return array;
}

void Show2DArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i], 2) +" ");
    Console.WriteLine();
}

double[] AverageOfColumns (int[,] array)
{
    double[] arrayAverage = new double[array.GetLength(1)];
    for (int j = 0, x=0; j < array.GetLength(0); j++)
    {   double sumColumns = 0;
        for (int i = 0; i < array.GetLength(1); i++)
           {
            sumColumns += array[i,j];
           } 
        arrayAverage[x] = sumColumns / (array.GetLength(0));   
        x++;    
    }     
    return arrayAverage; 
}

int [,] newArray = CreateRandom2DArray();
Show2DArray(newArray);

double [] myArray = AverageOfColumns(newArray);
ShowArray(myArray);
*/
