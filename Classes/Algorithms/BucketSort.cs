using DataStructuresAndAlgorithms_InCSharp.Interfaces.Algorithms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataStructuresAndAlgorithms_InCSharp.Classes.Algorithms
{
    public class BucketSort : ImethodAlgorithms
    {
        private static int iterations = 0;

        public BucketSort() { }

        public void Sort(int[] arr)
        {
            // Implementación para ordenar un array de enteros
        }

        public void Sort(double[] arr)
        {
            BucketSort_Double(arr);
            Console.WriteLine($"Number of iterations: {iterations}");
        }

        public void Sort(int[] array, ListBox listBX)
        {
            // Implementación para ordenar un array de enteros y mostrar pasos
        }

        public void Sort(double[] array, ListBox listBX)
        {
            BucketSort_Double(array, listBX);
            ShowStatistics(listBX);
        }

        static void PrintBucketState(List<double>[] buckets, ListBox listBX)
        {
            listBX.Items.Clear();
            for (int i = 0; i < buckets.Length; i++)
            {
                List<string> bucketContent = new List<string>();

                foreach (var item in buckets[i])
                {
                    bucketContent.Add(item.ToString());
                }

                listBX.Items.Add($"Bucket {i}: {string.Join(", ", bucketContent)}");
            }
        }

        static double[] BucketSort_Double(double[] array, ListBox listBX = null)
        {
            // Crear buckets vacíos
            List<double>[] buckets = new List<double>[array.Length];
            for (int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = new List<double>();
            }

            // Insertar elementos en sus respectivos buckets
            foreach (double element in array)
            {
                iterations++; // Incrementa el número de iteraciones
                buckets[(int)(element * array.Length)].Add(element);

                PrintBucketState(buckets, listBX);
                PrintArray(array, listBX);
            }

            // Imprimir el estado de los buckets después de la inserción
            PrintBucketState(buckets, listBX);

            // Ordenar los elementos de cada cubo
            for (int i = 0; i < array.Length; i++)
            {
                buckets[i].Sort();
            }

            // Imprimir el estado de los buckets después de la ordenación
            PrintBucketState(buckets, listBX);

            // Obtener los elementos ordenados
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                foreach (var item in buckets[i])
                {
                    array[k++] = item;
                }
            }

            return array;
        }

        private static void PrintArray(double[] array, ListBox listBX)
        {
            listBX.Items.Clear();
            foreach (var value in array)
            {
                listBX.Items.Add(value);
            }
        }

        private static void ShowStatistics(ListBox listBX)
        {
            listBX.Items.Add($"Number of iterations: {iterations}");
        }
    }
}
