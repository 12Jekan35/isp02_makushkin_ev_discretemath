using System;

namespace Sort_MakushkinISP_2
{
    static class Sort
    {
        public static void Swap(ref int firstItem, ref int secondItem)
        {
            int temp = firstItem;
            firstItem = secondItem;
            secondItem = temp;
        }
        public static void BubbleSort(int[] array)
        {
            if (array == null || array.Length < 2)
                return;

            bool swapped = false;
            while (true)
            {
                swapped = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);

                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }

        public static void SelectionSort(int[] array)
        {
            if (array == null || array.Length < 2)
                return;

            for (int i = 0; i < array.Length; i++)
            {
                int maxIndex = i;
                for (int next = i + 1; next < array.Length; next++)
                    if (array[maxIndex] < array[next])
                        maxIndex = next;

                if (maxIndex != i)
                    Swap(ref array[i], ref array[maxIndex]);
                
            }
        }
    }
}
