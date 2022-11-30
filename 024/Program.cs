/*Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.Clear();

input("k1");
double k1=Convert.ToDouble(Console.ReadLine());
input("b1");
double b1=Convert.ToDouble(Console.ReadLine());
input("k2");
double k2=Convert.ToDouble(Console.ReadLine());
input("b2");
double b2=Convert.ToDouble(Console.ReadLine());

Coord(k1,k2,b1,b2); 

void Coord(double k1, double k2, double b1, double b2)
{
  double [] coord = new double [2]; // coord[0]=x; coord[1]=y 
  
  if (k1==k2 && b1==b2)
    {
        Console.WriteLine("Линии совпадают. Вы ввели одинаковые коэффициенты для обеих строк.");
        return;
    } 
  else if (k1==k2)
    {
        Console.WriteLine("Линии паралельны.");
        return;
    }
  else
   {
       coord[0] = (b2-b1)/(k1-k2);
       coord[1] = k1*(b2-b1)/(k1-k2) + b1;
       Console.WriteLine("("+coord[0] + ";" + coord[1]+")");
   }
  
} 


void input (string nameCoeff)
{
   Console.Write($"Введите число {nameCoeff}: ") ;
}




