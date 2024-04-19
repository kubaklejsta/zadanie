using System;

public class AplikacjaSortowanie
{
    private const int ArrayLength = 10;

    public static void Main(string[] args)
    {
        int[] numbers = new int[ArrayLength];
        Console.WriteLine("wpisz liczby:");

        for (int i = 0; i < ArrayLength; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        SortArray(numbers);

        Console.WriteLine("posortowane liczby:");
        for (int i = 0; i < ArrayLength; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    private static void SortArray(int[] numbers)
    {
        for (int i = 0; i < ArrayLength - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < ArrayLength; j++)
            {
                if (numbers[j] > numbers[minIndex])
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                Swap(numbers, i, minIndex);
            }
        }
    }

    private static void Swap(int[] numbers, int i, int j)
    {
        int temp = numbers[i];
        numbers[i] = numbers[j];
        numbers[j] = temp;
    }
}
