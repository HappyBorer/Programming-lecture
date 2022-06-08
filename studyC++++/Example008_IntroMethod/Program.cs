int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int a1 = 15;
int a2 = 21;
int a3 = 39;
int a4 = 12;
int a5 = 23;
int a6 = 33;
int a7 = 13;
int a8 = 23;
int a9 = 31;
int max1 = Max(a1, a2, a3);
int max2 = Max(a4, a5, a6);
int max3 = Max(a7, a8, a9);
int max = Max(max1, max2, max3);
Console.WriteLine(max);
