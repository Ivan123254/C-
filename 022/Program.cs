/*
Задача 41: 
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/



int [] enterArray(int elementsCount)
{
    Console.Write("Введите размер массива :");
    elementsCount = int.Parse(Console.ReadLine());
    int[] mArray = new int[elementsCount];

    for (int i = 0; i < mArray.Length; i++)
    {
        System.Console.Write("Введите число под индексом " + i + ": = ");
        mArray[i] = int.Parse(Console.ReadLine());
    }
    return mArray;
}

int numPositiv(int[] mArray)
{
    int sum = 0;
    for (int i = 0; i < mArray.Length; i++)
    {
        if (mArray[i] > 0)
        {
            sum++;
        }
    }
Console.WriteLine("\t=>\t Положительных чисел = " + sum);
return sum;
}

void PrintArray(int[] mArray)
{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < mArray.Length; i++)
    {
        Console.Write(mArray[i] + ", ");
    }
 
}

int[] array = enterArray(1);
Console.WriteLine();
PrintArray(array);
int positiv = numPositiv(array);
Console.WriteLine();