using System;
using System.Linq;

namespace lab1_T2
{
    public delegate bool Delegate(int number, int k);
    class Program
    {
        static void Main()
        {
            Console.Write("Введіть масив чисел через пробіл: ");
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Console.Write("Введіть значення k: ");
            int k = int.Parse(Console.ReadLine());

            Delegate filterDelegate = IsMultiple;

            int[] filterArray1 = FilterWithoutWhere(array, k, filterDelegate);
            PrintArray(filterArray1);
          
            int[] filterArray2 = FilterWithWhere(array, k, filterDelegate);
            PrintArray(filterArray2);
        }

        static int[] FilterWithWhere(int[] array, int k, Delegate filter)
        {
            var result = array.Where(x => filter(x, k)).ToArray();
            return result;
        }

        static int[] FilterWithoutWhere(int[] array, int k, Delegate filter)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (filter(array[i], k))
                {
                    count++;
                }
            }

            int[] result = new int[count];
            count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (filter(array[i], k))
                {
                    result[count] = array[i];
                    count++;
                }
            }

            return result;
        }

        static bool IsMultiple(int number, int k)
        {
            if (number == 0)
            {
                return false;
            }
            return number % k == 0;
        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

