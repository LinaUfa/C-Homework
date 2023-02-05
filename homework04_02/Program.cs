// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
/*
bool IsPallindrom (int number)
{
    int result = 0;
    int exam = number;
    while (number != 0)
    { 
        result = result*10 + number%10;
        number = number / 10;
    }
    if (result == exam) return true;
    else return false;
}
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsPallindrom(num));
*/


//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
//между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53 
/*
double Distance3D (double x1, double y1, double x2, double y2, double z1, double z2)
{
    double resultX=Math.Pow((x2 - x1),2);
    double resultY=Math.Pow((y2 - y1),2);
    double resultZ=Math.Pow((z2 - z1),2);
    double result=Math.Sqrt(resultX+resultY+resultZ);
    return result;
}
Console.Write("Input coordinate x1 = ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coordinate y1 = ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coordinate z1 = ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coordinate x2 = ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coordinate y2 = ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coordinate z2 = ");
double z2 = Convert.ToInt32(Console.ReadLine());
double distance = Distance3D(x1, y1, x2, y2, z1, z2);
distance=Math.Round(distance, 2);
Console.WriteLine(distance);
*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
/*
void QubeNum (int number)
{
    int result = 1;
    while (result <= number)
    {
        Console.Write(Math.Pow(result,3)+ " ");
        result++;
    }
}
Console.Write("Input a number = ");
int number = Convert.ToInt32(Console.ReadLine());
QubeNum(number);
*/


