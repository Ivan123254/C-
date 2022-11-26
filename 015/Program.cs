/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int Array = Read("Введите длинну массива: ");

int[] rndArr = new int[Array];
Console.Write("[");
for (int i = 0; i < rndArr.Length; i++)
{
    rndArr[i] = new Random().Next(1,9);
    Console.Write(rndArr[i]);

    if (i == rndArr.Length - 1)
    {
        Console.Write("]");
    }
    else Console.Write(", ");
}


// Функция ввода
int Read(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
