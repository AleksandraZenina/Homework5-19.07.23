// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
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

int CountSumElements (int [] numbers)
{
    int count = 0;
    for (int i=0; i<numbers.Length; i++)
    {
        if (i%2 == 1)
        {
            count += numbers[i];
        }
    }
    return count;
}

void Task()
{
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    int count = CountSumElements(numbers);
    Console.WriteLine($"Сумма элементов массива с нечетными индексами равна {count}");
}
Task();