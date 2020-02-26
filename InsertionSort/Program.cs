using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 90, 110, 80, 30, 10, 20 };
            for (int i = 1; i < num.Length; i++)
            {
                int tmp = num[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    int tmpIndex = j + 1;
                    if (tmp < num[j])
                    {
                        num[tmpIndex] = num[j];
                        num[j] = tmp;
                    }
                }
            }
        }
    }
}
