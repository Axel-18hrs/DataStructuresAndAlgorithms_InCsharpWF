using DataStructuresAndAlgorithms_InCSharp.Classes;
using DataStructuresAndAlgorithms_InCSharp.Classes.Lists;
using DataStructuresAndAlgorithms_InCSharp.Classes.Stacks;
using DataStructuresAndAlgorithms_InCSharp.Interfaces;
using Listas.Interfaces;
using System.DirectoryServices.ActiveDirectory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataStructuresAndAlgorithms_InCsharpWF
{
    public partial class Form1 : Form
    {
        private ImethodLists<object> list;
        private ImethodStacks<object> stacks;
        public Form1()
        {
            InitializeComponent();
            pnlLists.Visible = false;
            pnlStacks.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlLists.Visible = true;
            pnlStacks.Visible = false;
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
    }
}
