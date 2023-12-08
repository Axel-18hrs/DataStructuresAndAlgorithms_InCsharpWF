using DataStructuresAndAlgorithms_InCSharp.Interfaces.Algorithms;
using System;

namespace DataStructuresAndAlgorithms_InCSharp.Classes.Algorithms
{
    public class Insertionsort : ImethodAlgorithms
    {
        private static int iterations = 0;

        public Insertionsort() { }

        public void Sort(int[] arr, ListBox listBX)
        {
            InsertionSortAlgorithm(arr, listBX);
            listBX.Items.Add($"Number of iterations: {iterations}");
        }

        public void Sort(double[] arr)
        {
            // Implementación para ordenar un array de doubles
        }

        public void InsertionSortAlgorithm(int[] arr, ListBox listBX)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Mover los elementos del subarreglo arr[0..i-1] que son mayores que key
                // a una posición adelante de su posición actual
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;

                    // Imprimir el arreglo completo en cada iteración
                    listBX.Items.Add("[ " + string.Join(", ", arr) + " ]");
                    iterations++; // Incrementa el número de iteraciones
                }
                arr[j + 1] = key;
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
