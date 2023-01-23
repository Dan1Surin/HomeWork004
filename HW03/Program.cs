// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] RandomArray(int size, int lRange, int rRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(lRange,rRange);//[lR,rR)
    }
return array;
}

void sumNotEven (int[] arr)
{
    int s = 0;//s - сумма чисел
    s = arr[0]; // 0 - четное число
    for (int i = 1; i < arr.Length; i++)
    {
        if (i%2 != 0)
        {
            //Console.WriteLine(s);//проверка
            s=arr[i]+s;
        }
    }
        Console.WriteLine(s);
}
int[] Array = RandomArray(5,0,10);
sumNotEven(Array);
Console.WriteLine(string.Join(",",Array));
