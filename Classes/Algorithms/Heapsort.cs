using DataStructuresAndAlgorithms_InCSharp.Interfaces.Algorithms;

namespace DataStructuresAndAlgorithms_InCSharp.Classes.Algorithms
{
    public class Heapsort : ImethodAlgorithms
    {
        private static int iterations = 0;

        public Heapsort() { }

        public void Sort(int[] arr, ListBox listBX)
        {
            int n = arr.Length;

            // Construir un heap (montículo) máximo
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i, listBX);
            }

            // Extraer elementos uno por uno del heap
            for (int i = n - 1; i > 0; i--)
            {
                // Mover la raíz actual al final
                Swap(ref arr[0], ref arr[i]);

                // Llamar a heapify en el subárbol reducido
                Heapify(arr, i, 0, listBX);

                // Imprimir el arreglo completo en cada intercambio
                listBX.Items.Add("[ " + string.Join(", ", arr) + " ]");
                iterations++; // Incrementa el número de iteraciones
            }
            listBX.Items.Add($"Number of iterations: {iterations}");
        }

        public void Sort(double[] arr)
        {
            // Implementación para ordenar un array de doubles
        }

        private static void Heapify(int[] arr, int n, int i, ListBox listBX)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            // Comparar con el hijo izquierdo
            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }

            // Comparar con el hijo derecho
            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }

            // Si el mayor no es la raíz
            if (largest != i)
            {
                Swap(ref arr[i], ref arr[largest]);

                // Recursivamente heapify el subárbol afectado
                Heapify(arr, n, largest, listBX);

                // Imprimir el arreglo completo en cada intercambio
                listBX.Items.Add("[ " + string.Join(", ", arr) + " ]");
                iterations++; // Incrementa el número de iteraciones
            }
            
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
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
