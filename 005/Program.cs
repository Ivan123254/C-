/*Задача 15:
Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Введите число от 1 до 7:");
int numberA = Convert.ToInt32(Console.ReadLine());
if ((numberA == 6) || (numberA == 7))
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}  

