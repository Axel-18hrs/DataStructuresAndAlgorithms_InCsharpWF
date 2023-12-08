using DataStructuresAndAlgorithms_InCSharp.Classes.Algorithms;
using DataStructuresAndAlgorithms_InCSharp.Classes.Graphs;
using DataStructuresAndAlgorithms_InCSharp.Classes.Lists;
using DataStructuresAndAlgorithms_InCSharp.Classes.Nodes;
using DataStructuresAndAlgorithms_InCSharp.Classes.Operations;
using DataStructuresAndAlgorithms_InCSharp.Classes.Operations.Algorithms;
using DataStructuresAndAlgorithms_InCSharp.Classes.Queues;
using DataStructuresAndAlgorithms_InCSharp.Classes.Stacks;
using DataStructuresAndAlgorithms_InCSharp.Classes.Tree;
using DataStructuresAndAlgorithms_InCSharp.Interfaces;
using DataStructuresAndAlgorithms_InCSharp.Interfaces.Algorithms;
using Listas.Interfaces;
using System.Security.Cryptography;

namespace DataStructuresAndAlgorithms_InCsharpWF
{
    public partial class Form1 : Form
    {
        private ImethodLists<object> list;
        private ImethodStacks<object> stacks;
        private ImethodQueues<object> queues;
        private ImethodAlgorithms algorithm;
        private BinaryTree tree;
        private Graph<object> graph;
        public Form1()
        {
            InitializeComponent();
            pnlLists.Visible = false;
            pnlStacks.Visible = false;
            pnlQueues.Visible = false;
            pnlTree.Visible = false;
            pnlGraph.Visible = false;
            pnlAlgorithmsOfSorting.Visible = false;
            gbxCircularQ.Visible = false;
            gbxPriorityQue.Visible = false;
            txtNumbersOfItemstoOrder.Text = "10";
            txtMinimumRangeAlgorithms.Text = "-5";
            txtMaximumRangeAlgorithms.Text = "5";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlLists.Visible = true;
            pnlStacks.Visible = false;
            pnlQueues.Visible = false;
            pnlTree.Visible = false;
            pnlGraph.Visible = false;
            pnlAlgorithmsOfSorting.Visible = false;
            list = new SimpleList<object>();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtNumbers.Text, out int age))
            {
                MessageBox.Show("Only numbers in the Age!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            list.Add(int.Parse(txtNumbers.Text));
            ShowLists();
            ClearTxtList();

        }
        public void ShowLists()
        {
            listLista.Items.Clear();
            foreach (var n in list.Show())
            {

                listLista.Items.Add(n);
            }
        }

        private void btnShowReverse_Click(object sender, EventArgs e)
        {
            if (list.IsEmpty())
            {
                MessageBox.Show("The list is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listLista.Items.Clear();
            foreach (var n in list.ShowRevers())
            {

                listLista.Items.Add(n);
            }
        }

        private void circularListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list = new CircularList<object>();
            pnlLists.Visible = true;
        }

        private void doublyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list = new DoublyListLinked<object>();
            pnlLists.Visible = true;
        }

        private void circularDoublyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list = new CircularDoublyLinkedList<object>();
            pnlLists.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtNumbers.Text, out var age))
            {
                MessageBox.Show("Only numbers in the Age!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            list.Search(int.Parse(txtNumbers.Text));
            ClearTxtList();
        }
        public void ClearTxtList()
        {
            txtNumbers.ResetText();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listLista.Items.Clear();
            list.Clear();
            ShowLists();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtNumbers.Text, out var number))
            {
                MessageBox.Show("Only numbers in the 'Number' box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            list.Delete(int.Parse(txtNumbers.Text));
            listLista.Items.Clear();
            ShowLists();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumberStack.Text, out var number))
            {
                MessageBox.Show("Only numbers in the 'Number' box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            stacks.Push(number);
            lsbStacks.Items.Clear();
            foreach (var stack in stacks.Show())
            {
                lsbStacks.Items.Add(stack);
            }
        }

        private void staticStackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbxMenuStackAll.Visible = false;
            gbxMenuStatickStack.Visible = true;
        }

        private void btnLengthStack_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLengthStacks.Text, out var number))
            {
                MessageBox.Show("Only numbers in the 'Lenght of static stack' box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            stacks = new StaticStack<object>(number);
            gbxMenuStatickStack.Visible = false;
            gbxMenuStackAll.Visible = true;
        }

        private void dinamicStackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stacks = new DinamicStack<object>();
            gbxMenuStatickStack.Visible = false;
            gbxMenuStackAll.Visible = true;
        }

        private void stacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlLists.Visible = false;
            pnlStacks.Visible = true;
            pnlQueues.Visible = false;
            pnlTree.Visible = false;
            pnlGraph.Visible = false;
            pnlAlgorithmsOfSorting.Visible = false;
            gbxMenuStatickStack.Visible = false;
            gbxMenuStackAll.Visible = false;
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            stacks.Pop();
            lsbStacks.Items.Clear();
            foreach (var stack in stacks.Show())
            {
                lsbStacks.Items.Add(stack);
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Element '{stacks.Peek()}' is at the top of the stack.", "-*-*-*-", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Number of elements in the stack: {stacks.Count()}", "-*-*-*-", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void regularQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbxPriorityQue.Visible = false;
            gbxCircularQ.Visible = false;
            gbxCircularQLenght.Visible = false;
            gbxQueueCircularM.Visible = true;
            lsbQueues.Items.Clear();
            queues = new RegularQueue<object>();
        }

        private void doubleQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbxPriorityQue.Visible = false;
            gbxCircularQ.Visible = false;
            gbxPriorityQue.Visible = false;
            gbxCircularQ.Visible = false;
            gbxCircularQLenght.Visible = false;
            gbxQueueCircularM.Visible = true;
            lsbQueues.Items.Clear();
            queues = new DoubleQueue<object>();
        }

        private void queuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlLists.Visible = false;
            pnlStacks.Visible = false;
            pnlQueues.Visible = true;
            pnlTree.Visible = false;
            pnlGraph.Visible = false;
            gbxPriorityQue.Visible = false;
            gbxCircularQ.Visible = false;
            gbxCircularQLenght.Visible = false;
            lsbQueues.Items.Clear();
            queues = new RegularQueue<object>();
        }

        private void priorityQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbxPriorityQue.Visible = true;
            gbxCircularQ.Visible = false;
            gbxCircularQLenght.Visible = false;
            gbxQueueCircularM.Visible = true;
            lsbQueues.Items.Clear();
            queues = new PriorityQueue<object>();
        }

        private void circularQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbxPriorityQue.Visible = false;
            gbxCircularQ.Visible = true;
            gbxCircularQLenght.Visible = true;
            gbxQueueCircularM.Visible = false;
            lsbQueues.Items.Clear();
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            int priority = 0;

            if (gbxPriorityQue.Visible == true && !int.TryParse(txtPriorityQ.Text, out priority))
            {
                MessageBox.Show($"Need a level of priority", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (gbxPriorityQue.Visible == true)
            {
                queues.Enqueue(txtNumbersQueue.Text, priority);
                PrintQueues();
            }

            queues.Enqueue(txtNumbersQueue.Text);
            PrintQueues();
        }

        private void btnEnqueueRear_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumbersQueue.Text, out var number))
            {
                MessageBox.Show("Only numbers in the 'numbers' box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            queues.EnqueueRear(number);
            PrintQueues();
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            queues.Dequeue();
            PrintQueues();
        }

        private void btnDequeueRear_Click(object sender, EventArgs e)
        {
            queues.DequeueRear();
            PrintQueues();
        }

        private void btnPeekQ_Click(object sender, EventArgs e)
        {
            queues.Peek();
        }

        private void btnPeekQRear_Click(object sender, EventArgs e)
        {
            queues.PeekRear();
        }

        public void PrintQueues()
        {
            lsbQueues.Items.Clear();
            foreach (var n in queues.Display())
            {
                lsbQueues.Items.Add(n);
            }
        }
        private void pnlQueues_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlLists.Visible = false;
            pnlQueues.Visible = false;
            pnlStacks.Visible = false;
            pnlTree.Visible = true;
            pnlAlgorithmsOfSorting.Visible = false;
            pnlGraph.Visible = false
            tree = new BinaryTree();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumberBinaryTree.Text, out var number))
            {
                MessageBox.Show("Only numbers in the 'numbers' box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tree.Add(number);
            ToursOfTree();
            int Data = 0;
            try { Data = int.Parse(txtNumberBinaryTree.Text); } catch { }

            tree.Add(Data);

            VisualizarArbol(tree.Root, null, treeView.Nodes);

            txtNumberBinaryTree.Clear();
            txtNumberBinaryTree.Focus();
        }

        private void btnDeleteTreeN_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumberBinaryTree.Text, out var number))
            {
                MessageBox.Show("Only numbers in the 'numbers' box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tree.Delete(number);
            ToursOfTree();
        }

        public void ToursOfTree()
        {
            lsbPreorder.Items.Clear();
            foreach (int val in tree.GetPreOrden())
            {
                lsbPreorder.Items.Add(val);
            }

            lsbPostOrder.Items.Clear();
            foreach (int val in tree.GetPostOrden())
            {
                lsbPostOrder.Items.Add(val);
            }

            lsbInOrder.Items.Clear();
            foreach (int val in tree.GetPreOrden())
            {
                lsbInOrder.Items.Add(val);
            }
        }
        private void btnSearchTreeN_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumberBinaryTree.Text, out var number))
            {
                MessageBox.Show("Only numbers in the 'numbers' box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tree.Search(number);
        }

        static void VisualizarArbol(BinaryNode Tree, TreeNode parentNode, TreeNodeCollection nodes)
        {
            if (Tree != null)
            {
                var NewNode = new TreeNode(Tree.Data.ToString());
                if (parentNode != null)
                {
                    parentNode.Nodes.Add(NewNode);
                }
                else
                {
                    nodes.Add(NewNode);
                }
                VisualizarArbol(Tree.Left, NewNode, NewNode.Nodes);
                VisualizarArbol(Tree.Right, NewNode, NewNode.Nodes);
            }
        }

        private void pnlTree_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private int CalculateTotalWeight(List<object> path)
        {
            int totalWeight = 0;

            for (int i = 0; i < path.Count - 1; i++)
            {
                var source = path[i];
                var destination = path[i + 1];

                foreach ((var neighbor, int weight) in graph.GetNeighbors(source))
                {
                    if (Equals(neighbor, destination))
                    {
                        totalWeight += weight;
                        break;
                    }
                }
            }

            return totalWeight;
        }

        private void MostrarMatrizAdyacencia()
        {
            List<string> matrizStrings = graph.GetAdjacencyMatrix();

            lsbAdyacencyMatrixGraph.Items.Clear();

            foreach (var row in matrizStrings)
            {
                lsbAdyacencyMatrixGraph.Items.Add(row);
            }
        }

        private void graphsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlLists.Visible = false;
            pnlQueues.Visible = false;
            pnlStacks.Visible = false;
            pnlTree.Visible = false;
            pnlGraph.Visible = true;
            pnlAlgorithmsOfSorting.Visible = false;
            graph = new Graph<object>();
        }

        private void ActualizarListBox()
        {
            lsbGraph.Items.Clear();

            foreach (var vertice in graph.GetVertices())
            {
                lsbGraph.Items.Add($"Vertex: {vertice}");
                foreach (var vecino in graph.GetVertices())
                {
                    lsbGraph.Items.Add($"  -> Neighbor: {vecino}");
                }
            }
        }

        private void btnAddVertGraph_Click(object sender, EventArgs e)
        {
            int vertice;

            if (!int.TryParse(txtNumberGraph.Text, out vertice))
            {
                MessageBox.Show("Only numbers in the boxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            graph.AddVertex(vertice);
            ActualizarListBox();
            MostrarMatrizAdyacencia();

            txtNumberGraph.Clear();


        }

        private void btnAddEdgeGraph_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtOriginGraph.Text, out int origin)
                || !int.TryParse(txtDestinationGraph.Text, out int destination)
                || !int.TryParse(txtWeightGraph.Text, out int weight))
            {
                MessageBox.Show("Only numbers in the boxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            graph.AddEdge(origin, destination, weight);

            ActualizarListBox();
            MostrarMatrizAdyacencia();
            MostrarMatrizAdyacencia();

            txtOriginGraph.Clear();
            txtDestinationGraph.Clear();
            txtWeightGraph.Clear();
        }

        private void btnToursDFSGraph_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtOriginGraph.Text, out int origen))
            {
                MessageBox.Show("Only numbers in the boxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resultadoDFS = graph.DFS(origen, -1);

            if (resultadoDFS.steps.Count <= 0)
            {
                lsbTourGraph.Items.Clear();
                MessageBox.Show($"No DFS traversal found from vertex {origen}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lsbTourGraph.Items.Clear();
            for (int i = 0; i < resultadoDFS.steps.Count; i++)
            {
                List<object> paso = resultadoDFS.steps[i];
                string pasoStr = string.Join(" -> ", paso);
                lsbTourGraph.Items.Add($"Step {i + 1}: {pasoStr}");
            }

            txtOriginGraph.Clear();
        }

        private void btnFindAwayGraph_Click(object sender, EventArgs e)
        {
            int origen, destino;
            if (!int.TryParse(txtOriginGraph.Text, out origen) || !int.TryParse(txtDestinationGraph.Text, out destino))
            {
                MessageBox.Show("Only numbers in the boxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resultadoDFS = graph.DFS(origen, destino);

            // Obtener el mejor camino desde la tupla
            List<object> mejorCamino = resultadoDFS.bestPath;

            if (mejorCamino.Count <= 0)
            {
                MessageBox.Show($"A path was not found from vertex {origen} to vertex {destino}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string caminoStr = string.Join(" -> ", mejorCamino);

            int pesoTotal = CalculateTotalWeight(mejorCamino);
            MessageBox.Show($"Best path found from vertex {origen} to vertex {destino}: {caminoStr}\n" +
                             $"Total weight of the path: {pesoTotal}", "-*-*-*-", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtOriginGraph.Clear();
            txtDestinationGraph.Clear();
        }

        private void btnDeleteGraph_Click(object sender, EventArgs e)
        {
            if (lsbGraph.SelectedItem == null)
            {
                MessageBox.Show("Select a vertex to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] partes = lsbGraph.SelectedItem.ToString().Split(':');

            int vertice = 0;
            if (!(partes.Length >= 2 && int.TryParse(partes[1].Trim(), out vertice)))
            {
                MessageBox.Show("Error extracting selected vertex.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            graph.RemoveVertex(vertice);
            ActualizarListBox();
        }

        private void btnStartQu_Click(object sender, EventArgs e)
        {
            int num;

            if (!int.TryParse(txtLenghtsQu.Text, out num))
            {
                MessageBox.Show("Only numbers in the box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            gbxCircularQ.Visible = false;
            gbxQueueCircularM.Visible = true;
            queues = new CircularQueue<object>(num);
        }

        private void btnCantOfItemsAlgorithms_Click(object sender, EventArgs e)
        {
            lsbAlgorithmSorting.Items.Clear();
            if (algorithm is null)
            {
                MessageBox.Show("Select an algorithm to order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Console.WriteLine("Enter the minimum range from which you want to generate your unordered array:");
            if (!int.TryParse(txtMinimumRangeAlgorithms.Text, out int minon))
            {
                OperationsList.Deffault();
                return;
            }

            Console.WriteLine("\nEnter the maximum range or limit where you want to generate your unordered array:");
            if (!int.TryParse(txtMaximumRangeAlgorithms.Text, out int length))
            {
                OperationsList.Deffault();
                return;
            }

            Console.WriteLine("\nEnter the number of values you want in your array:");
            if (!int.TryParse(txtNumbersOfItemstoOrder.Text, out int values))
            {
                OperationsList.Deffault();
                return;
            }

            if (algorithm is Countingsort && minon < 0 )
            {
                MessageBox.Show("Only numbers positives", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (algorithm is BucketSort)
            {
                double[] arr = OperationsAlgorithm.GenerarVectorDouble(minon, length, values);

                lsbAlgorithmSorting.Items.Add("Unordered array: " + "[ " + string.Join(", ", arr) + " ]");
                DateTime startTime = DateTime.Now;
                algorithm.Sort(arr, lsbAlgorithmSorting);
                lsbAlgorithmSorting.Items.Add("Sorted array: " + "[ " + string.Join(", ", arr) + " ]");
                lsbAlgorithmSorting.Items.Add("Time: " + (DateTime.Now - startTime));
            }
            else
            {
                int[] arr = OperationsAlgorithm.GenerarVector(minon, length, values);

                lsbAlgorithmSorting.Items.Add("Unordered array: " + "[ " + string.Join(", ", arr) + " ]");
                DateTime startTime = DateTime.Now;
                algorithm.Sort(arr, lsbAlgorithmSorting);
                lsbAlgorithmSorting.Items.Add("Sorted array: " + "[ " + string.Join(", ", arr) + " ]");
                lsbAlgorithmSorting.Items.Add("Time: " + (DateTime.Now - startTime));
            }
        }

        private void sortingAlgorithmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlGraph.Visible = false;
            pnlLists.Visible = false;
            pnlQueues.Visible = false;
            pnlStacks.Visible = false;
            pnlTree.Visible = false;
            pnlAlgorithmsOfSorting.Visible = true;
        }

        private void binaryTreeSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = new BinaryTreeSort();
        }

        private void bubbleSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = new BubbleSort();
        }

        private void cocktailSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = new CocktailSort();
        }

        private void combSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = new Combsort();
        }

        private void countingSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = new Countingsort();
        }

        private void gnomeSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = new Gnomesort();
        }

        private void heapSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = new Heapsort();
        }

        private void insertionSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = new Insertionsort();
        }

        private void mergeSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = new Mergesort();
        }

        private void pigeoholeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = new Pigeonhole();
        }

        private void quickSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = new QuickSort();
        }

        private void radixSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = new Radixsort();
        }

        private void selectionSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = new Selectionsort();
        }

        private void shellSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = new Shellsort();
        }

        private void smoothSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = new SmoothSort();
        }

        private void bucketSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            algorithm = new BucketSort();
        }
    }
}