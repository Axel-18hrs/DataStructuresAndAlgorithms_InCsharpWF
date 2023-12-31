﻿using DataStructuresAndAlgorithms_InCSharp.Interfaces.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms_InCSharp.Classes.Algorithms
{
    public class Combsort : ImethodAlgorithms
    {
        private static int iterations = 0;

        public Combsort() { }

        public void Sort(int[] arr, ListBox listBX)
        {
            int n = arr.Length;

            // Inicializar el tamaño del salto
            int gap = n;

            // Factor de reducción
            double shrink = 1.3;

            bool swapped;

            do
            {
                // Aplicar un salto mínimo de 1
                if (gap > 1)
                {
                    gap = (int)(gap / shrink);
                }

                swapped = false;

                // Realizar comparaciones y swaps
                for (int i = 0; i + gap < n; i++)
                {
                    if (arr[i] > arr[i + gap])
                    {
                        Swap(ref arr[i], ref arr[i + gap]);
                        swapped = true;
                    }
                }

                // Imprimir el arreglo completo en cada intercambio
                listBX.Items.Add("[ " + string.Join(", ", arr) + " ]");
                iterations++; // Incrementa el número de iteraciones
            } while (gap > 1 || swapped);
            listBX.Items.Add($"Number of iterations: {iterations}");
        }

        public void Sort(double[] arr)
        {
            // Implementación para ordenar un array de doubles
        }

        public void Sort(double[] array, ListBox listBX)
        {
            throw new NotImplementedException();
        }

        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public void Sort(int[] array)
        {
            throw new NotImplementedException();
        }
    }

}
