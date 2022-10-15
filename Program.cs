// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
/*
Console.WriteLine("Enter a number A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter a number B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter a number C: ");
int C = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter a number D: ");
int D = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter a number E: ");
int E = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter a number F: ");
int F = int.Parse(Console.ReadLine()!);

int count = 0;
if(A > 0)
{
    Console.WriteLine(A);
    count++;
}
if(B > 0)
{
    Console.WriteLine(B);
    count++;
}
if(C > 0)
{
    Console.WriteLine(C);
    count++;
}
if(D > 0)
{
    Console.WriteLine(D);
    count++;
}
if(E > 0)
{
    Console.WriteLine(E);
    count++;
}
if(F > 0)
{
    Console.WriteLine(F);
    count++;
}
Console.WriteLine($"Количество чисел, которые > 0 равно = {count}");
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Enter k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

var x = (k2-k1)/(b1+b2);
var y = k1*x+b1;
x = Math.Round(x, 3);  //оставляет 3 знака после запятой
y = Math.Round(y, 3);  // оставляет 3 знака после запятой
Console.WriteLine($"x = {x}, y = {y}");