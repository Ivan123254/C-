/*Задача 25:
Напишите цикл, который принимает 
на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 
*/


// Функция ввода
int ReadInt(string input)
{
    Console.Write(input);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция возведения в степень
void Vstepeny(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.Write(a + ", " + b + " -> " + result);
}


int numb1 = ReadInt("Введите число: ");
int numb2 = ReadInt("Введите степень: ");
Vstepeny(numb1, numb2);