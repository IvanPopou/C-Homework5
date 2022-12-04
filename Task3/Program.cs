//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

int[] GenerateArray(int Length, int min, int max)
{
    int[] array = new int[Length];
    
    for(int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

int MinMaxDifference(int[] array)
{
    int min = array[0];
    int max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];
    }
    int diff = max - min;
    return diff;
}

int[] arr = GenerateArray(10, -100, 100);
PrintArray(arr);

int difference = MinMaxDifference(arr);
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {difference}");