using SortingAlgorithms;
using SortingAlgorithms.BubbleSort;

//Console.WriteLine("Hello! Choose one of the sorting algorithms:");
var randomNumberTable = new RandomNumberTableGenerator();
var randomNumberArray = randomNumberTable.RandomNumberArray;


showArray(randomNumberArray, "losowych");

BubbleSort bubbleSort = new(randomNumberArray);

showArray(bubbleSort.InputArray, "posortowanych");

static void showArray(int[] array, string info)
{
    Console.Write($"Tablica {info} liczb: [");

    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write($"{array[i]}]");
            break;
        }
        Console.Write($"{ array[i]}, ");
    }
    Console.WriteLine();
}