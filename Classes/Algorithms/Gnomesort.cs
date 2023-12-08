using DataStructuresAndAlgorithms_InCSharp.Interfaces.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms_InCSharp.Classes.Algorithms
{
    public class Gnomesort : ImethodAlgorithms
    {
        private static int iterations = 0;

        public Gnomesort() { }

        public void Sort(int[] arr, ListBox listBX)
        {
            int n = arr.Length;
            int index = 0;

            while (index < n)
            {
                if (index == 0)
                {
                    index++;
                }
                if (arr[index] >= arr[index - 1])
                {
                    index++;
                }
                else
                {
                    Swap(ref arr[index], ref arr[index - 1]);
                    index--;

                    // Imprimir el arreglo completo en cada intercambio
                    listBX.Items.Add("[ " + string.Join(", ", arr) + " ]");
                    iterations++; // Incrementa el número de iteraciones
                }
            }
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

        private void ShowStatistics()
        {
            Console.WriteLine($"Number of iterations: {iterations}");
        }

        public void Sort(int[] array)
        {
            throw new NotImplementedException();
        }
    }
}
