﻿using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace lab1_T6
{
    delegate int[] SortingAlgorithm(int[] array);
    class Program
    {
        static void Main()
        {
            Program program = new Program();

            SortingAlgorithm standardSelectionSort = program.StandardSelectionSort;
            SortingAlgorithm studentSelectionSort = program.StudentSelectionSort;

            SortingAlgorithm standardShakerSort = program.StandardShakerSort;
            SortingAlgorithm studentShakerSort = program.StudentShakerSort;

            program.CompareStandardWithStudent(standardSelectionSort, studentSelectionSort);
            program.CompareStandardWithStudent(standardShakerSort, studentShakerSort);
        }

        int[] StandardSelectionSort(int[] array)
        {
            var len = array.Length;
            for (var i = 0; i < len - 1; i++)
            {
                var minIndex = i;
                for (var j = i + 1; j < len; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    (array[i], array[minIndex]) = (array[minIndex], array[i]);
                }
            }
            return array;
        }

        int[] StandardShakerSort(int[] array)
        {
            var len = array.Length;
            bool swapped;
            do
            {
                swapped = false;
                for (var i = 0; i < len - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
                swapped = false;
                for (var i = len - 2; i >= 0; i--)
                {
                    if (array[i] > array[i + 1])
                    {
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                        swapped = true;
                    }
                }
            } while (swapped);
            return array;
        }

        int[] StudentSelectionSort(int[] array)
        {
            int temp, smallest;
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {

                    if (array[j] < array[smallest])

                    { smallest = j; }

                }
                temp = array[smallest];
                array[smallest] = array[i];
                array[i] = temp;
            }
            return array;
        }

        int[] StudentShakerSort(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;
            int temp;
            bool swapped = true;
            while (left < right && swapped)
            {
                swapped = false;
                for (int i = left; i < right; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }
                right--;
                swapped = false;
                for (int j = right; j > left; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                        swapped = true;

                    }
                }
                left++;
            }
            return array;
        }

        void CompareStandardWithStudent(SortingAlgorithm standard, SortingAlgorithm student)
        {
            var arrayToSort = GenerateRandomArray(10000);

            double standardTime, studentTime;
            int[] arrForStandard = new int[arrayToSort.Length], arrForStudent = new int[arrayToSort.Length];

            using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(5));

            arrayToSort.CopyTo(arrForStandard, 0);
            arrayToSort.CopyTo(arrForStudent, 0);

            try
            {
                var st = Stopwatch.StartNew();
                standard(arrForStandard);
                st.Stop();
                standardTime = st.Elapsed.TotalMilliseconds;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Виникла помилка у стандартному методі: {e.Message}");
                return;
            }

            try
            {
                var st = Stopwatch.StartNew();

                var studentResult = Task.Run(() => student(arrForStudent), cancellationTokenSource.Token);
                studentResult.Wait(cancellationTokenSource.Token);

                st.Stop();
                studentTime = st.Elapsed.TotalMilliseconds;

                if (!IsArraySorted(studentResult.Result))
                {
                    Console.WriteLine("Студентський метод не відсортував масив правильно");
                    return;
                }
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Час виконання студентського методу перевищив 5 секунд");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Виникла помилка у студентському методі: {e.Message}");
                return;
            }

            if (standardTime - 200 <= studentTime && studentTime <= standardTime + 200)
            {
                Console.WriteLine("Алгоритми мають однаковий час виконання");
            }
            else
            {
                Console.WriteLine("Алгоритми мають різний час виконання");
            }

        }

        int[] GenerateRandomArray(int size)
        {
            var random = new Random();
            var array = new int[size];

            for (var i = 0; i < size; i++)
            {
                array[i] = random.Next(1,10000);
            }
            return array;
        }

        bool IsArraySorted(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1]) return false;
            }

            return true;
        }
    }
}
