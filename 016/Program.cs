/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2  */
int count = Read("Введите размер массива: ");
int [] numbers = new int[count];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++) //Подсчет четных в массиве
{
    if (numbers[i] % 2 == 0)
    {
        result++;
    }
}

    Console.WriteLine($"четных => {result} ");



void FillArrayRandomNumbers(int [] array) //Заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 1000);
    }
}

void PrintArray(int[] array) //Вывод массива на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+", ");
    }
}


int Read(string msg)  //Функция ввода
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}


