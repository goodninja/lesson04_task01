// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите первое число (A)>");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число (B)>");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

for (int i = 1; i < b; i++)
{
    step = step * a;
}
Console.WriteLine("Число A в степени B равно = " + step);
