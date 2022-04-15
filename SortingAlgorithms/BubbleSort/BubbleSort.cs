namespace SortingAlgorithms.BubbleSort
{
    public class BubbleSort
    {
        public int[] InputArray { get; set; }

        public BubbleSort(int[] arrayToSort)
        {
            InputArray = BubbleSortAlg(arrayToSort);
        }
        private static int[] BubbleSortAlg(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int k = 0; k < array.Length; k++)
                {
                    if (k == array.Length - 1)
                    {
                        break;
                    }
                    else if (array[k] > array[k + 1])
                    {
                        (array[k + 1], array[k]) = (array[k], array[k + 1]);
                    }
                }
            }
            return array;
        }
    }
}
