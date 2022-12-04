//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

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

int oddSumm(int[] array)
{
    int summ = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1) summ = summ + array[i];
    }
    return summ;
}

int[] arr = GenerateArray(10, -100, 100);
PrintArray(arr);

int summ = oddSumm(arr);
System.Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях равна {summ}");