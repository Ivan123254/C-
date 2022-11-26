/*Задача 38:
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/


int count = Read("Введите размер массива: ");
double [] numbers = new double[count];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);


double max = numbers[0];
double min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным числом = {max - min}");



void FillArrayRandomNumbers(double [] array) //Заполнение массива
{
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (rnd.NextDouble() * 1000) - 500;// значение Double от -500 до 500
    }
}

void PrintArray(double[] array) //Вывод массива на экран
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
