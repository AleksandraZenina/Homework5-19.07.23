// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void FillArray (double [] numbers, int minValue = -9, int maxValue = 9)
{
    maxValue++;
    Random rnd = new Random();
    for (int i =0; i<numbers.Length; i++)
    {
        numbers[i] = rnd.Next(minValue,maxValue) + rnd.NextDouble();
    }
}

void PrintArray (double[] numbers)
{
    for(int i=0; i<numbers.Length; i++)
    {
        Console.WriteLine($" {numbers[i]} ");
    }
    Console.WriteLine();
}

double MaxElementInSegment (double [] numbers)
{
    double max = numbers[0];
    for (int i=1; i<numbers.Length; i++)
    {
        if (numbers[i]>max)
        {
            max = numbers[i];
        }
    }
    return max;
}

double MinElementInSegment (double [] numbers)
{
    double min = numbers[0];
    for (int i=1; i<numbers.Length; i++)
    {
        if (numbers[i]<min)
        {
            min = numbers[i];
        }
    }
    return min;
}

void Task()
{
    int size = 10;
    double [] numbers = new double [size];
    FillArray(numbers);
    PrintArray(numbers);
    double count = MaxElementInSegment (numbers) - MinElementInSegment (numbers);
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {count}");
}
Task();
