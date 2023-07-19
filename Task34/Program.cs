// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
void FillArray (int[] numbers, int minValue = -9, int maxValue = 9)
{
    maxValue++;
    Random rnd = new Random();
    for (int i =0; i<numbers.Length; i++)
    {
        numbers[i]=rnd.Next(minValue,maxValue);
    }
}

void PrintArray (int[] numbers)
{
    for(int i=0; i<numbers.Length; i++)
    {
        Console.Write($" {numbers[i]} ");
    }
    Console.WriteLine();
}

int CountElementInSegment (int [] numbers)
{
    int count = 0;
    for (int i=0; i<numbers.Length; i++)
    {
        if (numbers[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}

void Task()
{
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, 100, 999);
    PrintArray(numbers);
    int count = CountElementInSegment(numbers);
    Console.WriteLine($"Количество четных элементов массива равно {count}");
}
Task();
