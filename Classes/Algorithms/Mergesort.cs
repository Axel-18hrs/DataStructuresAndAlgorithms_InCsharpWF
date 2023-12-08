using DataStructuresAndAlgorithms_InCSharp.Interfaces.Algorithms;
using System;

namespace DataStructuresAndAlgorithms_InCSharp.Classes.Algorithms
{
    public class Mergesort : ImethodAlgorithms
    {
        private static int iterations = 0;

        public Mergesort() { }

        public void Sort(int[] arr, ListBox listBX)
        {
            MergeSort(arr, listBX);
            listBX.Items.Add($"Number of iterations: {iterations}");
        }

        public void Sort(double[] arr)
        {
            // Implementación para ordenar un array de doubles
        }

        public static void MergeSort(int[] arr, ListBox listBX)
        {
            if (arr.Length < 2)
                return;

            int mid = arr.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[arr.Length - mid];

            Array.Copy(arr, 0, left, 0, mid);
            Array.Copy(arr, mid, right, 0, arr.Length - mid);

            MergeSort(left, listBX);
            MergeSort(right, listBX);
            Merge(arr, left, right, listBX);
        }

        public static void Merge(int[] arr, int[] left, int[] right, ListBox listBX)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;

                // Imprimir el arreglo completo en cada comparación
                listBX.Items.Add("[ " + string.Join(", ", arr) + " ]");
                iterations++; // Incrementa el número de iteraciones
            }

            while (i < left.Length)
            {
                arr[k] = left[i];
                i++;
                k++;

                // Imprimir el arreglo completo en cada comparación
                listBX.Items.Add("[ " + string.Join(", ", arr) + " ]");
                iterations++; // Incrementa el número de iteraciones
            }

            while (j < right.Length)
            {
                arr[k] = right[j];
                j++;
                k++;

                // Imprimir el arreglo completo en cada comparación
                listBX.Items.Add("[ " + string.Join(", ", arr) + " ]");
                iterations++; // Incrementa el número de iteraciones
            }
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
