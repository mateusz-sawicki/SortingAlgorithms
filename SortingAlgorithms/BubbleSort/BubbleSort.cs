namespace SortingAlgorithms.BubbleSort
{
    public class BubbleSort
    {
        public int[] inputArray { get; set; }

        public BubbleSort(int[] arrayToSort)
        {
            inputArray = BubbleSortAlg(arrayToSort);
        }
        private int[] BubbleSortAlg(int[] array)
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
                        int j = array[k];
                        array[k] = array[k + 1];
                        array[k + 1] = j;
                    }
                }
            }
            return array;
        }
    }
}
