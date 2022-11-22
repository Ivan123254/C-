/*
Задача 13:
Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Введите число:");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = (int)Math.Log10(numberA)-2;
if (numberB < 0)
{
    System.Console.WriteLine("Третьей цифры нет."); 
}
else
{
    string number3 = (numberA % (int)Math.Pow(10, numberB + 1) / (int)Math.Pow(10, numberB)).ToString();
    System.Console.WriteLine("Третья цифра = " + number3); 
}