/*Задача 25:
Напишите цикл, который принимает 
на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 
*/

    int numberA, numberB, numberC;

    numberA = int.Parse(Console.ReadLine());
    numberB = int.Parse(Console.ReadLine());
    numberC = 1;
    for (int i = 0; i < numberB; i++)
    {
        numberC = numberC * numberA;
    }
    Console.WriteLine(numberA + ", " + numberB + " -> " + numberC);

