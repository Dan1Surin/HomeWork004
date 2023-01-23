// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] RandomArray(int size, int lRange, int rRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(lRange,rRange);//[lR,rR)
    }
return array;
}

void searchNumbers (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {  
       int x = 0;
       x = arr[i];
       if (x >= 10 && x <= 99 )
       {
        count=count+1;
       }
       
    }
    Console.WriteLine($" таких чисел - {count}");
}
int[] Array = RandomArray(123,0,150);
//Console.WriteLine(string.Join(",",Array));
searchNumbers(Array);