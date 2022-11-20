/*
Задача 4: 
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Write("Введите число а: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if(max < numberB)
{
    max = numberB;   
} 
if(max < numberC)
{
    max = numberC;
}
Console.Write("max = ");
Console.Write(max);
