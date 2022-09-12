/*
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Write a 5 digit number: ");
int a = int.Parse(Console.ReadLine());

if (a > 99999 || a<10000) 
    {
    Console.WriteLine("Please check your number and write 5 digit number: ");
    }
else
    {
    int a1digit = a / 10000;
    int a2digit = (a / 1000) %10;
    int a3digit = (a / 100) %10;
    int a4digit = (a / 10) %10;
    int a5digit = a %10;

    if (a1digit == a5digit && a2digit == a4digit)
       {
        Console.WriteLine("It's a numeric palindrome");
       } 
    else
        {
            Console.WriteLine("It is't a numeric palindrome");
        }
    }
    */

    /*
    // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.5

// формулы https://ru.onlinemschool.com/math/library/analytic_geometry/point_point_length/

double Distance(double x1, double y1, double z1, double x2, double y2,double z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1, 2)),2);
}

Console.WriteLine(Distance(3,6,8,2,1,-7));
Console.WriteLine(Distance(7,-5, 0,1,-1,9));
*/

/*
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void x (int a)
{
    int b = 1;
    while(b <=a)
    {
        Console.WriteLine(Math.Pow(b, 3));
        b++;
    }
}
x(3);
x(5);
*/
