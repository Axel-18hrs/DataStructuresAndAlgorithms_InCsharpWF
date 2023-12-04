namespace DataStructuresAndAlgorithms_InCsharpWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBeggininMessage = new Label();
            menuStrip1 = new MenuStrip();
            listsToolStripMenuItem = new ToolStripMenuItem();
            simpleListToolStripMenuItem = new ToolStripMenuItem();
            circularListToolStripMenuItem = new ToolStripMenuItem();
            doublyListToolStripMenuItem = new ToolStripMenuItem();
            circularDoublyListToolStripMenuItem = new ToolStripMenuItem();
            stacksToolStripMenuItem = new ToolStripMenuItem();
            queuesToolStripMenuItem = new ToolStripMenuItem();
            treesToolStripMenuItem = new ToolStripMenuItem();
            graphsToolStripMenuItem = new ToolStripMenuItem();
            pnlLists = new Panel();
            btnDelete = new Button();
            btnShowReverse = new Button();
            btnSearch = new Button();
            listLista = new ListBox();
            btnSend = new Button();
            lblAdress = new Label();
            lblAge = new Label();
            lblName = new Label();
            txtAdress = new TextBox();
            txtAge = new TextBox();
            txtName = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip1.SuspendLayout();
            pnlLists.SuspendLayout();
            SuspendLayout();
            // 
            // lblBeggininMessage
            // 
            lblBeggininMessage.AutoSize = true;
            lblBeggininMessage.Font = new Font("Yu Gothic UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBeggininMessage.Location = new Point(385, 153);
            lblBeggininMessage.Name = "lblBeggininMessage";
            lblBeggininMessage.Size = new Size(329, 60);
            lblBeggininMessage.TabIndex = 11;
            lblBeggininMessage.Text = "Data structures";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { listsToolStripMenuItem, stacksToolStripMenuItem, queuesToolStripMenuItem, treesToolStripMenuItem, graphsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1127, 28);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // listsToolStripMenuItem
            // 
            listsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { simpleListToolStripMenuItem, circularListToolStripMenuItem, doublyListToolStripMenuItem, circularDoublyListToolStripMenuItem });
            listsToolStripMenuItem.Name = "listsToolStripMenuItem";
            listsToolStripMenuItem.Size = new Size(51, 24);
            listsToolStripMenuItem.Text = "Lists";
            listsToolStripMenuItem.Click += listsToolStripMenuItem_Click;
            // 
            // simpleListToolStripMenuItem
            // 
            simpleListToolStripMenuItem.Name = "simpleListToolStripMenuItem";
            simpleListToolStripMenuItem.Size = new Size(220, 26);
            simpleListToolStripMenuItem.Text = "Simple List";
            // 
            // circularListToolStripMenuItem
            // 
            circularListToolStripMenuItem.Name = "circularListToolStripMenuItem";
            circularListToolStripMenuItem.Size = new Size(220, 26);
            circularListToolStripMenuItem.Text = "Circular List";
            circularListToolStripMenuItem.Click += circularListToolStripMenuItem_Click;
            // 
            // doublyListToolStripMenuItem
            // 
            doublyListToolStripMenuItem.Name = "doublyListToolStripMenuItem";
            doublyListToolStripMenuItem.Size = new Size(220, 26);
            doublyListToolStripMenuItem.Text = "Doubly List";
            doublyListToolStripMenuItem.Click += doublyListToolStripMenuItem_Click;
            // 
            // circularDoublyListToolStripMenuItem
            // 
            circularDoublyListToolStripMenuItem.Name = "circularDoublyListToolStripMenuItem";
            circularDoublyListToolStripMenuItem.Size = new Size(220, 26);
            circularDoublyListToolStripMenuItem.Text = "Circular Doubly List";
            circularDoublyListToolStripMenuItem.Click += circularDoublyListToolStripMenuItem_Click;
            // 
            // stacksToolStripMenuItem
            // 
            stacksToolStripMenuItem.Name = "stacksToolStripMenuItem";
            stacksToolStripMenuItem.Size = new Size(64, 24);
            stacksToolStripMenuItem.Text = "Stacks";
            // 
            // queuesToolStripMenuItem
            // 
            queuesToolStripMenuItem.Name = "queuesToolStripMenuItem";
            queuesToolStripMenuItem.Size = new Size(72, 24);
            queuesToolStripMenuItem.Text = "Queues";
            // 
            // treesToolStripMenuItem
            // 
            treesToolStripMenuItem.Name = "treesToolStripMenuItem";
            treesToolStripMenuItem.Size = new Size(57, 24);
            treesToolStripMenuItem.Text = "Trees";
            // 
            // graphsToolStripMenuItem
            // 
            graphsToolStripMenuItem.Name = "graphsToolStripMenuItem";
            graphsToolStripMenuItem.Size = new Size(69, 24);
            graphsToolStripMenuItem.Text = "Graphs";
            // 
            // pnlLists
            // 
            pnlLists.Controls.Add(btnDelete);
            pnlLists.Controls.Add(btnShowReverse);
            pnlLists.Controls.Add(btnSearch);
            pnlLists.Controls.Add(listLista);
            pnlLists.Controls.Add(btnSend);
            pnlLists.Controls.Add(lblAdress);
            pnlLists.Controls.Add(lblAge);
            pnlLists.Controls.Add(lblName);
            pnlLists.Controls.Add(txtAdress);
            pnlLists.Controls.Add(txtAge);
            pnlLists.Controls.Add(txtName);
            pnlLists.Location = new Point(2, 31);
            pnlLists.Name = "pnlLists";
            pnlLists.Size = new Size(1125, 498);
            pnlLists.TabIndex = 13;
            pnlLists.Visible = false;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(93, 372);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(159, 40);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnShowReverse
            // 
            btnShowReverse.Location = new Point(643, 417);
            btnShowReverse.Name = "btnShowReverse";
            btnShowReverse.Size = new Size(159, 40);
            btnShowReverse.TabIndex = 10;
            btnShowReverse.Text = "Reverse";
            btnShowReverse.UseVisualStyleBackColor = true;
            btnShowReverse.Click += btnShowReverse_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(93, 326);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(159, 40);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // listLista
            // 
            listLista.Font = new Font("Segoe UI", 12F);
            listLista.FormattingEnabled = true;
            listLista.ItemHeight = 28;
            listLista.Location = new Point(643, 70);
            listLista.Margin = new Padding(3, 4, 3, 4);
            listLista.Name = "listLista";
            listLista.Size = new Size(394, 340);
            listLista.TabIndex = 8;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(93, 280);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(159, 40);
            btnSend.TabIndex = 7;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Location = new Point(93, 198);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(53, 20);
            lblAdress.TabIndex = 6;
            lblAdress.Text = "Adress";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(93, 127);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(36, 20);
            lblAge.TabIndex = 5;
            lblAge.Text = "Age";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(93, 61);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // txtAdress
            // 
            txtAdress.ImeMode = ImeMode.NoControl;
            txtAdress.Location = new Point(93, 221);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(253, 27);
            txtAdress.TabIndex = 3;
            // 
            // txtAge
            // 
            txtAge.ImeMode = ImeMode.NoControl;
            txtAge.Location = new Point(93, 150);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(253, 27);
            txtAge.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.ImeMode = ImeMode.NoControl;
            txtName.Location = new Point(93, 84);
            txtName.Name = "txtName";
            txtName.Size = new Size(253, 27);
            txtName.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1127, 527);
            Controls.Add(pnlLists);
            Controls.Add(menuStrip1);
            Controls.Add(lblBeggininMessage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlLists.ResumeLayout(false);
            pnlLists.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBeggininMessage;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem listsToolStripMenuItem;
        private ToolStripMenuItem stacksToolStripMenuItem;
        private ToolStripMenuItem queuesToolStripMenuItem;
        private ToolStripMenuItem treesToolStripMenuItem;
        private ToolStripMenuItem graphsToolStripMenuItem;
        private Panel pnlLists;
        private Label lblName;
        private TextBox txtAdress;
        private TextBox txtAge;
        private TextBox txtName;
        private Button btnSend;
        private Label lblAdress;
        private Label lblAge;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListBox listLista;
        private Button btnShowReverse;
        private Button btnSearch;
        private Button btnDelete;
        private ToolStripMenuItem circularListToolStripMenuItem;
        private ToolStripMenuItem doublyListToolStripMenuItem;
        private ToolStripMenuItem circularDoublyListToolStripMenuItem;
        private ToolStripMenuItem simpleListToolStripMenuItem;
    }
}
