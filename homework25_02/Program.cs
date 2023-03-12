//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void ShowNums (int num)
{
    Console.Write(num + " ");
    if (num > 1) ShowNums(num -1);
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowNums(number);
*/

//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*
int SumOfNumbers (int m, int n)
{
    if (m <= n) return SumOfNumbers(m+1, n) + m;
    else return 0;
}
Console.Write("Input a number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = SumOfNumbers(number1, number2);
Console.WriteLine(result);
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
/*
int Akkerman (int n, int m)
{
  if (n == 0)
    return m + 1;
    else
    if ((n != 0) && (m == 0))
        return Akkerman(n - 1, 1);
    else
        return Akkerman(n - 1, Akkerman(n, m - 1));
}
Console.Write("Input a number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = Akkerman(number1,number2);
Console.WriteLine(result);
*/