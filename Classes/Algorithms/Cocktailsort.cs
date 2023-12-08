using DataStructuresAndAlgorithms_InCSharp.Interfaces.Algorithms;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms_InCSharp.Classes.Algorithms
{
    public class CocktailSort : ImethodAlgorithms
    {
        private static int iterations = 0;

        public CocktailSort() { }

        public void Sort(int[] arr)
        {
            CocktailSort_Int(arr);
            ShowStatistics();
        }

        public void Sort(double[] arr)
        {
            // Implementación para ordenar un array de doubles
        }

        public void Sort(int[] array, ListBox listBX)
        {
            CocktailSort_Int(array, listBX);
            listBX.Items.Add($"Number of iterations: {iterations}");
        }

        public void Sort(double[] array, ListBox listBX)
        {
            // Implementación para ordenar un array de doubles y mostrar pasos
        }

        private void CocktailSort_Int(int[] arr, ListBox listBX = null)
        {
            int n = arr.Length;
            bool swapped = true;
            int start = 0;
            int end = n - 1;

            while (swapped)
            {
                // Mover de izquierda a derecha
                swapped = false;
                for (int i = start; i < end; i++)
                {
                    iterations++; // Incrementa el número de iteraciones
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i, i + 1);
                        swapped = true;
                        listBX.Items.Add("[ " + string.Join(", ", arr) + " ]");
                    }
                }

                if (!swapped)
                {
                    break;
                }

                end--;

                // Mover de derecha a izquierda
                swapped = false;
                for (int i = end - 1; i >= start; i--)
                {
                    iterations++; // Incrementa el número de iteraciones
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i, i + 1);
                        swapped = true;
                        listBX.Items.Add("[ " + string.Join(", ", arr) + " ]");
                    }
                }

                start++;
            }
        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        private void PrintArray(int[] array, ListBox listBX)
        {
            listBX.Items.Clear();
            foreach (var value in array)
            {
                listBX.Items.Add(value);
            }
        }

        private void ShowStatistics()
        {
            Console.WriteLine($"Number of iterations: {iterations}");
        }
    }
}
