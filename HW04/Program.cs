// Задача 38: Задайте массив натуральных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] RandomArray(int size, int lRange, int rRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(lRange,rRange);//[lR,rR)
    }
return array;
}

int maxNmb(int[] arr)
{
    int Max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>Max)
        {
            Max=arr[i];
            //Console.WriteLine(Max);//проверка
        }
    }
    return Max;
}
int minNmb(int[] arr)
{
    int Min = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]<Min)
        {
            Min=arr[i];
            //Console.WriteLine(Min);//проверка
        }
    }
    return Min;
}

int[] Array = RandomArray(10,-10,10);
Console.WriteLine(string.Join(",",Array));//проверка
int Min = minNmb(Array);
int Max = maxNmb(Array);
int x = 0;
x=Max-Min;
Console.WriteLine($"разница между максимальным и минимальным элементами = {x}");