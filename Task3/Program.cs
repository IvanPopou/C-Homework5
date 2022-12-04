//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

double[] GenerateArray(int Length, double min, double max)
{
    double[] array = new double[Length];
    
    for(int i = 0; i < Length; i++)
    {
        array[i] = min + new Random().NextDouble() * (max - min);
    }
    return array;
}

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

double MinMaxDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];
    }
    double diff = max - min;
    return diff;
}

double[] arr = GenerateArray(10, -10, 10);
PrintArray(arr);

double difference = MinMaxDifference(arr);
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {difference}");