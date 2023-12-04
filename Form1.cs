using DataStructuresAndAlgorithms_InCSharp.Classes;
using DataStructuresAndAlgorithms_InCSharp.Classes.Lists;
using Listas.Interfaces;
using System.DirectoryServices.ActiveDirectory;

namespace DataStructuresAndAlgorithms_InCsharpWF
{
    public partial class Form1 : Form
    {
        private ImethodLists<object> list;
        public Form1()
        {
            InitializeComponent();
            list = new SimpleList<object>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlLists.Visible = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Only numbers in the Age!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            list.Add(new Person(age, txtName.Text, txtAdress.Text));
            ShowLists();
            ClearTxtList();

        }
        public void ShowLists()
        {
            foreach (var n in list.Show())
            {
                // Suponiendo que Person tiene una propiedad llamada Name
                string personName = ((Person)n).ToString();

                listLista.Items.Add(personName);
            }
        }

        private void btnShowReverse_Click(object sender, EventArgs e)
        {
            if (list.IsEmpty())
            {
                MessageBox.Show("The list is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Console.Clear();
            foreach (var n in list.ShowRevers())
            {
                // Suponiendo que Person tiene una propiedad llamada Name
                string personName = ((Person)n).ToString();

                listLista.Items.Add(personName);
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
           
            if (!int.TryParse(txtAge.Text, out var age))
            {
                MessageBox.Show("Only numbers in the Age!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            list.Search(new Person(age, txtName.Text, txtAdress.Text));
            ClearTxtList();
        }
        public void ClearTxtList()
        {
            txtAge.ResetText();
            txtName.ResetText();
            txtAdress.ResetText();
        }
    }
}
