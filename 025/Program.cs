/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/
int countM = Read("Введите размер массива M: ");
int countN = Read("Введите размер массива N: ");
double[,] arrNew = new double[countM,countN];
printArray(arrNew);

double[,] randArray(int countM,int countN)
{
    double[,] arrNew = new double[countM,countN];
    Random random = new Random();
    for (int i = 0; i < countM; i++)
    {
        for (int j = 0; j < countN; j++)
        {
            arrNew[i, j] = random.NextDouble() * 100 - 50;
            
        }
       
    }
    return arrNew;
}

void printArray(double[,] arrNew)
{
     for (int i = 0; i < countM; i++)
    {
        for (int j = 0; j < countN; j++)
        {
            Console.Write(arrNew[i,j]+"\t");    
            
        }
        Console.WriteLine();
    }
}

int Read(string msg) 
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
