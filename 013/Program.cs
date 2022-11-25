/*Задача 25:
Напишите цикл, который принимает 
на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 
*/


    int numberA = read("Введите число A: ");
    int numberB = read("Введите число B: ");
    stepeny(numberA, numberB);


void stepeny(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(numberA + ", " + numberB + " -> " + result);
}


int read(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

