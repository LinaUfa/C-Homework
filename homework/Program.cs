// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
/*
int ShowSecondNum(int number)
{
    int dec = number / 10;
    
    int result = dec % 10;
    return result;
}
Console.Write("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int newNum = ShowSecondNum(num);
Console.WriteLine($"{newNum} is the second symbol of number {num}");
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день 
//недели, и проверяет, является ли этот день выходным.
/*
void WeekendDay(int dayNumber)
{
    if (dayNumber == 6) Console.WriteLine("Этот день выходной");
    if (dayNumber == 7) Console.WriteLine("Этот день выходной");
    if (dayNumber <= 5) Console.WriteLine("Этот день не выходной");
}
Console.WriteLine("Input number of day from 1 to 7: ");
int weekDay = Convert.ToInt32(Console.ReadLine());
WeekendDay(weekDay);
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа.
/*
int ShowThirdNum (int number)
{
    while (number > 1000)
    {
      number = number / 10;  
    }
int result = number % 10;
return result;
}

Console.Write("Input a number: ");
int num=Convert.ToInt32(Console.ReadLine());
int numThird = ShowThirdNum(num);
Console.Write($"Your third number is {numThird}");
/*

