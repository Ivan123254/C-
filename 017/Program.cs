/*Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
int count = Read("Введите размер массива: ");
int [] numbers = new int[count];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++) //Подсчет суммы нечетных позиций
{
    if (i % 2 != 0)
    {
        result = result + numbers[i];
    }

}

    Console.WriteLine($"Сумма нечетных позиций => {result} ");



void FillArrayRandomNumbers(int [] array) //Заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 99);
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

