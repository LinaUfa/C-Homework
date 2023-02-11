//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
//число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*
double Stepen (double numA, double numB)
{
    double res = Math.Pow(numA, numB);
    return res;
}
Console.Write("Input number A: ");
double numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
double numB = Convert.ToInt32(Console.ReadLine());
double result = Stepen(numA, numB);
Console.Write($"Число {numA} в степени {numB} будет равно {result}");
*/


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*
int SumNumbers (int number)
{
    int result=0;
    while (number != 0)
        {
            result=result + number%10;
            number=number/10;
        }    
    return result;
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = SumNumbers(num);
Console.WriteLine($"Сумма цифр в числе {num} равна {sum}");
*/

//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

/*int[] CreateRandomArray (int size, int minValue, int maxValue)
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
Console.Write("Input size: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
*/