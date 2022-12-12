/*
Задача 41: 
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/


//начало 1й функции.
Console.Write("Введите размер массива :");
int elementsCount = int.Parse(Console.ReadLine());
int[] mArray = new int[elementsCount];

for (int i = 0; i < mArray.Length; i++)
{
    System.Console.Write("Введите число под индексом "+i+": = ");
    mArray[i] = int.Parse(Console.ReadLine());
}
// конец 1й функции
//начало 2й функции
int sum = 0;
for (int i = 0; i < mArray.Length; i++)
{
    if (mArray[i] > 0)
    {
        sum++;
    }

}
//конец 2й функции
//начало 3й функции
Console.WriteLine("Вывод массива:");
for (int i = 0; i < mArray.Length; i++)
{
    Console.Write(mArray[i]+", ");   
}
Console.WriteLine("\t Положительных чисел = "+sum);
//конец 3й функции.
