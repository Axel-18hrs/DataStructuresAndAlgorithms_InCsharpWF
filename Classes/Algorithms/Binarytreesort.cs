using DataStructuresAndAlgorithms_InCSharp.Interfaces.Algorithms;

namespace DataStructuresAndAlgorithms_InCSharp.Classes.Algorithms
{
    internal class BinarytreeNode
    {
        public int Value;
        public BinarytreeNode Left, Right;

        public BinarytreeNode(int value)
        {
            Value = value;
            Left = Right = null;
        }
    }

    public class BinaryTreeSort : ImethodAlgorithms
    {
        public BinaryTreeSort() { }

        private BinarytreeNode root;
        private int swaps = 0;
        private int recursions = 0;

        public void Sort(int[] arr)
        {
            foreach (var value in arr)
            {
                root = Insert(root, value);
            }
            InOrderTraversal(root, arr, ref index);
            Console.WriteLine($"Number of swaps: {swaps}");
            Console.WriteLine($"Number of recursions: {recursions}");
        }

        public void Sort(int[] arr, ListBox listBX)
        {
            foreach (var value in arr)
            {
                root = Insert(root, value);
                PrintTree(listBX);
            }
            InOrderTraversal(root, arr, ref index, listBX);
            
            listBX.Items.Add($"Number of swaps: {swaps}");
            listBX.Items.Add($"Number of recursions: {recursions}");
        }

        private BinarytreeNode Insert(BinarytreeNode node, int value)
        {
            if (node == null)
            {
                return new BinarytreeNode(value);
            }

            if (value < node.Value)
            {
                swaps++; // Incrementa el número de intercambios
                node.Left = Insert(node.Left, value);
            }
            else if (value > node.Value)
            {
                swaps++; // Incrementa el número de intercambios
                node.Right = Insert(node.Right, value);
            }

            return node;
        }

        private int index = 0;

        private void InOrderTraversal(BinarytreeNode node, int[] arr, ref int index)
        {
            recursions++; // Incrementa el número de recursiones
            if (node != null)
            {
                InOrderTraversal(node.Left, arr, ref index);
                arr[index++] = node.Value;
                InOrderTraversal(node.Right, arr, ref index);
            }
        }

        private void InOrderTraversal(BinarytreeNode node, int[] arr, ref int index, ListBox listBX)
        {
            recursions++; // Incrementa el número de recursiones
            if (node != null)
            {
                InOrderTraversal(node.Left, arr, ref index, listBX);
                arr[index++] = node.Value;
                PrintTree(listBX);
                InOrderTraversal(node.Right, arr, ref index, listBX);
            }
        }

        private void PrintTree(ListBox listBX)
        {
            listBX.Items.Clear();
            PrintTree(root, listBX);
        }

        private void PrintTree(BinarytreeNode node, ListBox listBX, string indent = "", bool last = true)
        {
            if (node != null)
            {
                listBX.Items.Add($"{indent}|- {node.Value}");
                indent += last ? "   " : "|  ";
                PrintTree(node.Left, listBX, indent, false);
                PrintTree(node.Right, listBX, indent, true);
            }
        }

        public void Sort(double[] arr)
        {
            // Implementación para ordenar un array de doubles
        }

        public void Sort(double[] arr, ListBox listBX)
        {
            // Implementación para ordenar un array de doubles y mostrar pasos
        }
    }
}
