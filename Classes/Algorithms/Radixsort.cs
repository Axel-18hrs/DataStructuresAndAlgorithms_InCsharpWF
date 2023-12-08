using DataStructuresAndAlgorithms_InCSharp.Interfaces.Algorithms;

namespace DataStructuresAndAlgorithms_InCSharp.Classes.Algorithms
{
    public class Radixsort : ImethodAlgorithms
    {
        private int iterations = 0;

        public Radixsort() { }

        public void Sort(int[] arr, ListBox listBX)
        {
            int max = FindMax(arr);

            // Aplicar Radix Sort para cada posición del dígito
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSort(arr, exp, listBX);
            }

            // Mostrar el número total de iteraciones al finalizar
            ShowIterations(listBX);
        }

        public void Sort(double[] arr)
        {
            // Implementación para ordenar un array de doubles
        }

        public void Sort(double[] array, ListBox listBX)
        {
            throw new NotImplementedException();
        }

        private void CountingSort(int[] arr, int exp, ListBox listBX)
        {
            int n = arr.Length;
            int[] output = new int[n];
            int[] count = new int[10];

            // Inicializar el arreglo de conteo
            for (int i = 0; i < 10; i++)
            {
                count[i] = 0;
            }

            // Contar la frecuencia de cada elemento en la posición actual del dígito
            for (int i = 0; i < n; i++)
            {
                count[(arr[i] / exp) % 10]++;
            }

            // Actualizar el arreglo de conteo para contener las posiciones reales
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            // Construir el arreglo de salida
            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            // Copiar el arreglo de salida de vuelta al arreglo original
            for (int i = 0; i < n; i++)
            {
                arr[i] = output[i];
            }

            // Mostrar el estado actual del arreglo en el ListBox
            PrintArray(arr, listBX);
            // Incrementar el contador de iteraciones
            iterations++;
        }

        private void PrintArray(int[] array, ListBox listBX)
        {
            listBX.Items.Add("[ " + string.Join(", ", array) + " ]");
        }

        private void ShowIterations(ListBox listBX)
        {
            listBX.Items.Add($"Number of iterations: {iterations}");
        }

        private int FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public void Sort(int[] array)
        {
            throw new NotImplementedException();
        }
    }
}
