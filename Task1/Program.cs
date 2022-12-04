// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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

int EvenCounter(int[] array)
{
    int counter = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) counter++;
    }
    return counter;
}

int[] arr = GenerateArray(10, 100, 1000);
PrintArray(arr);

int even = EvenCounter(arr);
System.Console.WriteLine($"Количество чётных чисел в массиве составляет {even}");
