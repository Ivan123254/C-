/*
Задача 27: 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int number = Read("Введите число: ");
int ind = cikl(number);
Sum(number, ind);

// Функция подсчета цифр в числе
int cikl(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

// Функция вывода суммы цифр в числе
void Sum(int n, int leng)
{
    int sum = 0;
    for (int i = 1; i <= leng; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.Write(number + " -> " + sum);
}

// Функция ввода
int Read(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
