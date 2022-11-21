// пишем первую функцию

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int a1 = 8;
int b1 = 15;
int c1 = 18;

int max1 = Max(a1, b1, c1);
Console.Write(max1);
