using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class RandomNumberTableGenerator
    {
        public int[] RandomNumberArray { get; set; }
        private readonly Random RandomNumber = new();


        public RandomNumberTableGenerator()
        {
            Console.WriteLine("Wpisz ilość elementów tablicy: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wpisz maksymalną możliwą liczbę w tablicy: ");
            int arrayNumberRange = Convert.ToInt32(Console.ReadLine());

            RandomNumberArray = GenarateArray(arraySize, arrayNumberRange);
        }
        private int[] GenarateArray(int arraySize, int arrayNumberRange)
        {
            int[] array = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                array[i] = RandomNumber.Next(0,arrayNumberRange);
            }

            return array;
        }
    }
}
