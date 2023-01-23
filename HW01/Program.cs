// Задача 34: Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу, которая покажет количество чётных
//   чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] RandomArray(int size, int lRange, int rRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(lRange,rRange);//[lR,rR)
    }
return array;
}



void evenNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {  
        if (arr[i]%2 == 0 )
        {
            count=count+1;
        }
    }
    Console.WriteLine($" четных чисел - {count}");
}
int[] massive= RandomArray(20,100,1000);
Console.WriteLine(string.Join(",",massive));
evenNumber(massive);