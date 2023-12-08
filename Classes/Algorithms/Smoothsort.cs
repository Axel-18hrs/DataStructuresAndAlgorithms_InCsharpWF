using DataStructuresAndAlgorithms_InCSharp.Interfaces.Algorithms;

namespace DataStructuresAndAlgorithms_InCSharp.Classes.Algorithms
{
    public class SmoothSort : ImethodAlgorithms
    {
        private int[] heap;
        private int iterations;
        public SmoothSort() { }

        public void Sort(int[] array, ListBox listBX)
        {
            heap = array;
            int n = array.Length;

            for (int i = (n - 1) / 2; i >= 0; i--)
            {
                SiftDown(i, n - 1, listBX);
            }

            for (int i = n - 1; i > 0; i--)
            {
                Swap(0, i);
                listBX.Items.Add("[ " + string.Join(", ", array) + " ]");
                SiftDown(0, i - 1, listBX);
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

        private void SiftDown(int root, int end, ListBox listBX)
        {
            iterations++;
            int leftChild = 2 * root + 1;
            while (leftChild <= end)
            {
                int rightChild = leftChild + 1;
                int swapIndex = root;

                if (heap[swapIndex] < heap[leftChild])
                {
                    swapIndex = leftChild;
                }

                if (rightChild <= end && heap[swapIndex] < heap[rightChild])
                {
                    swapIndex = rightChild;
                }

                if (swapIndex == root)
                {
                    return;
                }
                else
                {
                    Swap(root, swapIndex);
                    root = swapIndex;
                    leftChild = 2 * root + 1;

                }
            }
        }

        private void Swap(int i, int j)
        {
            int temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }

        public void Sort(int[] array)
        {
            throw new NotImplementedException();
        }
    }
}
