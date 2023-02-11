//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int [size];

    for (int i=0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue+1);
return array;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array [i]+" ");
    Console.WriteLine();
}

int CountOfEvenElements (int[] array)
{
       
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
         if(array[i]%2 == 0)
             count++; 
    }
    return count;
    
}
Console.Write("Input size: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);

int count = CountOfEvenElements(myArray);
Console.WriteLine(count);
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int [size];

    for (int i=0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue+1);
return array;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array [i]+" ");
    Console.WriteLine();
}

int SumofOddPositions (int[]array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    sum+=array[i];
    return sum;
}
Console.Write("Input size: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);

int sum = SumofOddPositions(myArray);
Console.WriteLine(sum);
*/

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*
int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int [size];

    for (int i=0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue+1);
return array;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array [i]+" ");
    Console.WriteLine();
}

int DifferenceMinMax (int[] array)
{
    int min=array[0];
    int max=array[0];
    for (int i = 0; i < array.Length; i++)
        if(array[i] < min) min = array[i];
    for (int i = 0; i < array.Length; i++)
        if(array[i] > max) max = array[i];
    int diff=max - min;
    return diff;
}
Console.Write("Input size: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);

int difference = DifferenceMinMax(myArray);
Console.WriteLine(difference);
*/