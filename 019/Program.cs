/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

int[] GenerateRandomArray(int length,int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint+1);
    }
    return resultArray;
}

int[] multElementsOfArray(int[] array)
{
    int lengthNewArray = array.Length / 2;
    if (array.Length % 2 != 0)
    {
        lengthNewArray = lengthNewArray + 1;
    }
    int[] newArray = new int [lengthNewArray];
    for (int i = 0; i < array.Length / 2; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }
    
    if (array.Length % 2 != 0)
    {
        newArray[lengthNewArray-1] = array[lengthNewArray-1];
    }

    return newArray;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}


int[] array = GenerateRandomArray(9,0,10);
printArray(array);
int[] multArray = multElementsOfArray(array);
printArray(multArray);
int[] array1 = GenerateRandomArray(10,0,10);
printArray(array1);
int[] multArray1 = multElementsOfArray(array1);
 
 