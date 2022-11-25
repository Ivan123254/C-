/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Write("Введите 5ти значное число: ");
int number = int.Parse(Console.ReadLine());
if (number <= 99999 && number >= 10000)
{
    int number10000 = number / 10000;
    int number1000  = (((number % 10000) % 1000) % 100) / 10;
    
    if ((number10000 == (number % 10)) && (number1000 == (number % 100/10)))
    {
       
        System.Console.Write("Палиндром!");    
    }
    else
    {
        System.Console.Write("Не Палиндром!");
    }


} 
else
{
    System.Console.WriteLine("Неверное число!");
}
