using DataStructuresAndAlgorithms_InCSharp.Interfaces.Algorithms;
using System;

namespace DataStructuresAndAlgorithms_InCSharp.Classes.Algorithms
{
    public class Shellsort : ImethodAlgorithms
    {
        private int iterations = 0;

        public Shellsort() { }

        public void Sort(int[] arr, ListBox listBX)
        {
            ShellSort(arr, listBX);
            listBX.Items.Add($"Number of iterations: {iterations}");
        }

        public void Sort(double[] arr)
        {
            // Implementation for sorting an array of doubles
        }

        public void ShellSort(int[] array, ListBox listBX = null)
        {
            // Get the length of the array
            int n = array.Length;
            // Get the gap size between elements
            int gap = n / 2;

            Console.WriteLine("\nStart of Shell Sort algorithm:");

            // While the gap between elements is greater than 0
            while (gap > 0)
            {
                Console.WriteLine($"\nCurrent Gap: {gap}");

                // Apply the insertion algorithm for each "subarray" with the gap size
                for (int i = gap; i < n; i++)
                {
                    // Save the current value of the element in a temporary variable
                    int temp = array[i];
                    int j = i;

                    Console.WriteLine($"\nComparing {temp} with the elements in its subarray:");

                    // Perform the insertion
                    while (j >= gap && array[j - gap] > temp)
                    {
                        // Shift elements to the right until finding the correct position
                        array[j] = array[j - gap];
                        j -= gap;
                        listBX?.Items.Add("[ " + string.Join(", ", array) + " ]");
                        iterations++; // Increment the number of iterations
                    }

                    // Place the temporary value in the correct position in the subarray
                    array[j] = temp;
                    Console.WriteLine($"Insert {temp} at position {j} in the subarray:");

                    if (listBX != null)
                    {
                        listBX.Items.Add("[ " + string.Join(", ", array) + " ]");
                    }

                    iterations++; // Increment the number of iterations
                }

                // Reduce the gap between elements by half in each iteration
                gap /= 2;
            }

            Console.WriteLine("\nEnd of Shell Sort algorithm:");
        }

        public void Sort(double[] array, ListBox listBX)
        {
            throw new NotImplementedException();
        }

        public void Sort(int[] array)
        {
            throw new NotImplementedException();
        }
    }


}
