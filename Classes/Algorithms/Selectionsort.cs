using DataStructuresAndAlgorithms_InCSharp.Interfaces.Algorithms;

namespace DataStructuresAndAlgorithms_InCSharp.Classes.Algorithms
{
    public class Selectionsort : ImethodAlgorithms
    {
        private int iterations = 0;

        public Selectionsort() { }

        public void Sort(int[] arr, ListBox listBX)
        {
            SelectionSortAlgorithm(arr, listBX);
            ShowIterations(listBX);
        }

        public void Sort(double[] arr)
        {
            // Implementación para ordenar un array de doubles
        }

        private void SelectionSortAlgorithm(int[] arr, ListBox listBX)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                // Encontrar el índice del mínimo elemento en el subarreglo no ordenado
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                    iterations++; // Incrementar el número de iteraciones
                    PrintArray(arr, listBX);
                }

                // Intercambiar el mínimo encontrado con el primer elemento del subarreglo no ordenado
                Swap(ref arr[i], ref arr[minIndex]);
                PrintArray(arr, listBX);
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void PrintArray(int[] array, ListBox listBX)
        {
            listBX.Items.Add("[ " + string.Join(", ", array) + " ]");
        }

        private void ShowIterations(ListBox listBX)
        {
            listBX.Items.Add($"Number of iterations: {iterations}");
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
