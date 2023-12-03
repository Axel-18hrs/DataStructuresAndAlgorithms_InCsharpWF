using DataStructuresAndAlgorithms_InCSharp.Classes;
using Listas.Interfaces;

namespace DataStructuresAndAlgorithms_InCsharpWF
{
    public partial class Form1 : Form
    {
        private ImethodLists<object> list;
        public Form1()
        {
            InitializeComponent();
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

        }
        public void ShowLists()
        {
            
        }
    }
}
