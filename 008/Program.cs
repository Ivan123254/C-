
/*
12 Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/
int Number1 = new Random().Next(11, 101);
int Number2 = new Random().Next(1, 11);
int result = 0;

int MultipleNumber()
{
    result = Number1 % Number2;
    return result;
}

MultipleNumber();

System.Console.WriteLine();
if (result == 0) System.Console.WriteLine($"Число {Number1} кратно числу {Number2}");
else
{
    Console.WriteLine($"Число {Number1} не кратно числу {Number2}, остаток от деления равен {Number1 % Number2}");
}
System.Console.WriteLine();

