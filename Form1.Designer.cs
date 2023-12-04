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
            staticStackToolStripMenuItem = new ToolStripMenuItem();
            dinamicStackToolStripMenuItem = new ToolStripMenuItem();
            queuesToolStripMenuItem = new ToolStripMenuItem();
            treesToolStripMenuItem = new ToolStripMenuItem();
            graphsToolStripMenuItem = new ToolStripMenuItem();
            pnlLists = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnShowReverse = new Button();
            btnSearch = new Button();
            listLista = new ListBox();
            btnSend = new Button();
            lblNumbers = new Label();
            txtNumbers = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pnlStacks = new Panel();
            gbxMenuStackAll = new GroupBox();
            btnPeek = new Button();
            btnCount = new Button();
            btnPop = new Button();
            btnPush = new Button();
            label1 = new Label();
            txtNumberStack = new TextBox();
            gbxMenuStatickStack = new GroupBox();
            btnLengthStack = new Button();
            lblLenghtStack = new Label();
            txtLengthStacks = new TextBox();
            lsbStacks = new ListBox();
            menuStrip1.SuspendLayout();
            pnlLists.SuspendLayout();
            pnlStacks.SuspendLayout();
            gbxMenuStackAll.SuspendLayout();
            gbxMenuStatickStack.SuspendLayout();
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
            stacksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { staticStackToolStripMenuItem, dinamicStackToolStripMenuItem });
            stacksToolStripMenuItem.Name = "stacksToolStripMenuItem";
            stacksToolStripMenuItem.Size = new Size(64, 24);
            stacksToolStripMenuItem.Text = "Stacks";
            stacksToolStripMenuItem.Click += stacksToolStripMenuItem_Click;
            // 
            // staticStackToolStripMenuItem
            // 
            staticStackToolStripMenuItem.Name = "staticStackToolStripMenuItem";
            staticStackToolStripMenuItem.Size = new Size(224, 26);
            staticStackToolStripMenuItem.Text = "Static Stack";
            staticStackToolStripMenuItem.Click += staticStackToolStripMenuItem_Click;
            // 
            // dinamicStackToolStripMenuItem
            // 
            dinamicStackToolStripMenuItem.Name = "dinamicStackToolStripMenuItem";
            dinamicStackToolStripMenuItem.Size = new Size(224, 26);
            dinamicStackToolStripMenuItem.Text = "Dinamic Stack";
            dinamicStackToolStripMenuItem.Click += dinamicStackToolStripMenuItem_Click;
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
            pnlLists.Controls.Add(btnClear);
            pnlLists.Controls.Add(btnDelete);
            pnlLists.Controls.Add(btnShowReverse);
            pnlLists.Controls.Add(btnSearch);
            pnlLists.Controls.Add(listLista);
            pnlLists.Controls.Add(btnSend);
            pnlLists.Controls.Add(lblNumbers);
            pnlLists.Controls.Add(txtNumbers);
            pnlLists.Location = new Point(2, 31);
            pnlLists.Name = "pnlLists";
            pnlLists.Size = new Size(1125, 498);
            pnlLists.TabIndex = 13;
            pnlLists.Visible = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(808, 417);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(159, 40);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(93, 372);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(159, 40);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
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
            // lblNumbers
            // 
            lblNumbers.AutoSize = true;
            lblNumbers.Location = new Point(93, 127);
            lblNumbers.Name = "lblNumbers";
            lblNumbers.Size = new Size(63, 20);
            lblNumbers.TabIndex = 5;
            lblNumbers.Text = "Number";
            // 
            // txtNumbers
            // 
            txtNumbers.ImeMode = ImeMode.NoControl;
            txtNumbers.Location = new Point(93, 150);
            txtNumbers.Name = "txtNumbers";
            txtNumbers.Size = new Size(253, 27);
            txtNumbers.TabIndex = 2;
            // 
            // pnlStacks
            // 
            pnlStacks.Controls.Add(gbxMenuStackAll);
            pnlStacks.Controls.Add(gbxMenuStatickStack);
            pnlStacks.Controls.Add(lsbStacks);
            pnlStacks.Location = new Point(0, 31);
            pnlStacks.Name = "pnlStacks";
            pnlStacks.Size = new Size(1127, 498);
            pnlStacks.TabIndex = 14;
            // 
            // gbxMenuStackAll
            // 
            gbxMenuStackAll.Controls.Add(btnPeek);
            gbxMenuStackAll.Controls.Add(btnCount);
            gbxMenuStackAll.Controls.Add(btnPop);
            gbxMenuStackAll.Controls.Add(btnPush);
            gbxMenuStackAll.Controls.Add(label1);
            gbxMenuStackAll.Controls.Add(txtNumberStack);
            gbxMenuStackAll.Location = new Point(55, 168);
            gbxMenuStackAll.Name = "gbxMenuStackAll";
            gbxMenuStackAll.Size = new Size(381, 275);
            gbxMenuStackAll.TabIndex = 23;
            gbxMenuStackAll.TabStop = false;
            // 
            // btnPeek
            // 
            btnPeek.Location = new Point(40, 170);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(159, 40);
            btnPeek.TabIndex = 19;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += btnPeek_Click;
            // 
            // btnCount
            // 
            btnCount.Location = new Point(40, 216);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(159, 40);
            btnCount.TabIndex = 18;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(40, 124);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(159, 40);
            btnPop.TabIndex = 17;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // btnPush
            // 
            btnPush.Location = new Point(40, 78);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(159, 40);
            btnPush.TabIndex = 16;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 16);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 15;
            label1.Text = "Number";
            // 
            // txtNumberStack
            // 
            txtNumberStack.ImeMode = ImeMode.NoControl;
            txtNumberStack.Location = new Point(40, 39);
            txtNumberStack.Name = "txtNumberStack";
            txtNumberStack.Size = new Size(253, 27);
            txtNumberStack.TabIndex = 14;
            // 
            // gbxMenuStatickStack
            // 
            gbxMenuStatickStack.Controls.Add(btnLengthStack);
            gbxMenuStatickStack.Controls.Add(lblLenghtStack);
            gbxMenuStatickStack.Controls.Add(txtLengthStacks);
            gbxMenuStatickStack.Location = new Point(64, 40);
            gbxMenuStatickStack.Name = "gbxMenuStatickStack";
            gbxMenuStatickStack.Size = new Size(318, 131);
            gbxMenuStatickStack.TabIndex = 22;
            gbxMenuStatickStack.TabStop = false;
            // 
            // btnLengthStack
            // 
            btnLengthStack.Location = new Point(31, 82);
            btnLengthStack.Name = "btnLengthStack";
            btnLengthStack.Size = new Size(159, 40);
            btnLengthStack.TabIndex = 21;
            btnLengthStack.Text = "Start";
            btnLengthStack.UseVisualStyleBackColor = true;
            btnLengthStack.Click += btnLengthStack_Click;
            // 
            // lblLenghtStack
            // 
            lblLenghtStack.AutoSize = true;
            lblLenghtStack.Location = new Point(31, 22);
            lblLenghtStack.Name = "lblLenghtStack";
            lblLenghtStack.Size = new Size(148, 20);
            lblLenghtStack.TabIndex = 20;
            lblLenghtStack.Text = "Lenght of static stack";
            // 
            // txtLengthStacks
            // 
            txtLengthStacks.ImeMode = ImeMode.NoControl;
            txtLengthStacks.Location = new Point(31, 45);
            txtLengthStacks.Name = "txtLengthStacks";
            txtLengthStacks.Size = new Size(253, 27);
            txtLengthStacks.TabIndex = 19;
            // 
            // lsbStacks
            // 
            lsbStacks.Font = new Font("Segoe UI", 12F);
            lsbStacks.FormattingEnabled = true;
            lsbStacks.ItemHeight = 28;
            lsbStacks.Location = new Point(627, 85);
            lsbStacks.Margin = new Padding(3, 4, 3, 4);
            lsbStacks.Name = "lsbStacks";
            lsbStacks.Size = new Size(394, 340);
            lsbStacks.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1127, 527);
            Controls.Add(pnlStacks);
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
            pnlStacks.ResumeLayout(false);
            gbxMenuStackAll.ResumeLayout(false);
            gbxMenuStackAll.PerformLayout();
            gbxMenuStatickStack.ResumeLayout(false);
            gbxMenuStatickStack.PerformLayout();
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
        private TextBox txtNumbers;
        private Button btnSend;
        private Label lblNumbers;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListBox listLista;
        private Button btnShowReverse;
        private Button btnSearch;
        private Button btnDelete;
        private ToolStripMenuItem circularListToolStripMenuItem;
        private ToolStripMenuItem doublyListToolStripMenuItem;
        private ToolStripMenuItem circularDoublyListToolStripMenuItem;
        private ToolStripMenuItem simpleListToolStripMenuItem;
        private Button btnClear;
        private Panel pnlStacks;
        private ListBox lsbStacks;
        private Button btnCount;
        private Button btnPop;
        private Button btnPush;
        private Label label1;
        private TextBox txtNumberStack;
        private ToolStripMenuItem staticStackToolStripMenuItem;
        private ToolStripMenuItem dinamicStackToolStripMenuItem;
        private Button btnLengthStack;
        private Label lblLenghtStack;
        private TextBox txtLengthStacks;
        private GroupBox gbxMenuStatickStack;
        private GroupBox gbxMenuStackAll;
        private Button btnPeek;
    }
}
