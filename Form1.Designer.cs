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
            regularQueueToolStripMenuItem = new ToolStripMenuItem();
            doubleQueueToolStripMenuItem = new ToolStripMenuItem();
            priorityQueueToolStripMenuItem = new ToolStripMenuItem();
            circularQueueToolStripMenuItem = new ToolStripMenuItem();
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
            pnlQueues = new Panel();
            pnlTreeGraphic = new Panel();
            label7 = new Label();
            InOrder = new ListBox();
            label6 = new Label();
            lsbPostOrder = new ListBox();
            label5 = new Label();
            lsbPreorder = new ListBox();
            lblBinaryTree = new Label();
            btnAdd = new Button();
            label4 = new Label();
            txtNumberBinaryTree = new TextBox();
            lsbBinaryTree = new ListBox();
            gbxCircularQLenght = new GroupBox();
            lblLenght = new Label();
            textBox1 = new TextBox();
            gbxPriorityQue = new GroupBox();
            label3 = new Label();
            txtPriorityQ = new TextBox();
            gbxCircularQ = new GroupBox();
            btnPeekQRear = new Button();
            btnDequeueRear = new Button();
            btnEnqueueRear = new Button();
            btnPeekQ = new Button();
            btnDequeue = new Button();
            btnEnqueue = new Button();
            label2 = new Label();
            txtNumbersQueue = new TextBox();
            lsbQueues = new ListBox();
            btnDeleteTreeN = new Button();
            btnSearchTreeN = new Button();
            menuStrip1.SuspendLayout();
            pnlLists.SuspendLayout();
            pnlStacks.SuspendLayout();
            gbxMenuStackAll.SuspendLayout();
            gbxMenuStatickStack.SuspendLayout();
            pnlQueues.SuspendLayout();
            pnlTreeGraphic.SuspendLayout();
            gbxCircularQLenght.SuspendLayout();
            gbxPriorityQue.SuspendLayout();
            gbxCircularQ.SuspendLayout();
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
            staticStackToolStripMenuItem.Size = new Size(186, 26);
            staticStackToolStripMenuItem.Text = "Static Stack";
            staticStackToolStripMenuItem.Click += staticStackToolStripMenuItem_Click;
            // 
            // dinamicStackToolStripMenuItem
            // 
            dinamicStackToolStripMenuItem.Name = "dinamicStackToolStripMenuItem";
            dinamicStackToolStripMenuItem.Size = new Size(186, 26);
            dinamicStackToolStripMenuItem.Text = "Dinamic Stack";
            dinamicStackToolStripMenuItem.Click += dinamicStackToolStripMenuItem_Click;
            // 
            // queuesToolStripMenuItem
            // 
            queuesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { regularQueueToolStripMenuItem, doubleQueueToolStripMenuItem, priorityQueueToolStripMenuItem, circularQueueToolStripMenuItem });
            queuesToolStripMenuItem.Name = "queuesToolStripMenuItem";
            queuesToolStripMenuItem.Size = new Size(72, 24);
            queuesToolStripMenuItem.Text = "Queues";
            queuesToolStripMenuItem.Click += queuesToolStripMenuItem_Click;
            // 
            // regularQueueToolStripMenuItem
            // 
            regularQueueToolStripMenuItem.Name = "regularQueueToolStripMenuItem";
            regularQueueToolStripMenuItem.Size = new Size(190, 26);
            regularQueueToolStripMenuItem.Text = "Regular Queue";
            regularQueueToolStripMenuItem.Click += regularQueueToolStripMenuItem_Click;
            // 
            // doubleQueueToolStripMenuItem
            // 
            doubleQueueToolStripMenuItem.Name = "doubleQueueToolStripMenuItem";
            doubleQueueToolStripMenuItem.Size = new Size(190, 26);
            doubleQueueToolStripMenuItem.Text = "Double Queue";
            doubleQueueToolStripMenuItem.Click += doubleQueueToolStripMenuItem_Click;
            // 
            // priorityQueueToolStripMenuItem
            // 
            priorityQueueToolStripMenuItem.Name = "priorityQueueToolStripMenuItem";
            priorityQueueToolStripMenuItem.Size = new Size(190, 26);
            priorityQueueToolStripMenuItem.Text = "Priority Queue";
            priorityQueueToolStripMenuItem.Click += priorityQueueToolStripMenuItem_Click;
            // 
            // circularQueueToolStripMenuItem
            // 
            circularQueueToolStripMenuItem.Name = "circularQueueToolStripMenuItem";
            circularQueueToolStripMenuItem.Size = new Size(190, 26);
            circularQueueToolStripMenuItem.Text = "Circular Queue";
            circularQueueToolStripMenuItem.Click += circularQueueToolStripMenuItem_Click;
            // 
            // treesToolStripMenuItem
            // 
            treesToolStripMenuItem.Name = "treesToolStripMenuItem";
            treesToolStripMenuItem.Size = new Size(51, 24);
            treesToolStripMenuItem.Text = "Tree";
            treesToolStripMenuItem.Click += treesToolStripMenuItem_Click;
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
            btnCount.Click += btnCount_Click;
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
            // pnlQueues
            // 
            pnlQueues.Controls.Add(pnlTreeGraphic);
            pnlQueues.Controls.Add(gbxCircularQLenght);
            pnlQueues.Controls.Add(gbxPriorityQue);
            pnlQueues.Controls.Add(gbxCircularQ);
            pnlQueues.Controls.Add(btnPeekQ);
            pnlQueues.Controls.Add(btnDequeue);
            pnlQueues.Controls.Add(btnEnqueue);
            pnlQueues.Controls.Add(label2);
            pnlQueues.Controls.Add(txtNumbersQueue);
            pnlQueues.Controls.Add(lsbQueues);
            pnlQueues.Location = new Point(0, 31);
            pnlQueues.Name = "pnlQueues";
            pnlQueues.Size = new Size(1127, 495);
            pnlQueues.TabIndex = 15;
            pnlQueues.Paint += pnlQueues_Paint;
            // 
            // pnlTreeGraphic
            // 
            pnlTreeGraphic.Controls.Add(btnSearchTreeN);
            pnlTreeGraphic.Controls.Add(btnDeleteTreeN);
            pnlTreeGraphic.Controls.Add(label7);
            pnlTreeGraphic.Controls.Add(InOrder);
            pnlTreeGraphic.Controls.Add(label6);
            pnlTreeGraphic.Controls.Add(lsbPostOrder);
            pnlTreeGraphic.Controls.Add(label5);
            pnlTreeGraphic.Controls.Add(lsbPreorder);
            pnlTreeGraphic.Controls.Add(lblBinaryTree);
            pnlTreeGraphic.Controls.Add(btnAdd);
            pnlTreeGraphic.Controls.Add(label4);
            pnlTreeGraphic.Controls.Add(txtNumberBinaryTree);
            pnlTreeGraphic.Controls.Add(lsbBinaryTree);
            pnlTreeGraphic.Location = new Point(0, 0);
            pnlTreeGraphic.Name = "pnlTreeGraphic";
            pnlTreeGraphic.Size = new Size(1127, 498);
            pnlTreeGraphic.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(405, 341);
            label7.Name = "label7";
            label7.Size = new Size(101, 26);
            label7.TabIndex = 34;
            label7.Text = "InOrder";
            // 
            // InOrder
            // 
            InOrder.Font = new Font("Segoe UI", 12F);
            InOrder.FormattingEnabled = true;
            InOrder.ItemHeight = 28;
            InOrder.Location = new Point(405, 371);
            InOrder.Margin = new Padding(3, 4, 3, 4);
            InOrder.Name = "InOrder";
            InOrder.Size = new Size(234, 116);
            InOrder.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(405, 174);
            label6.Name = "label6";
            label6.Size = new Size(124, 26);
            label6.TabIndex = 32;
            label6.Text = "PostOrder";
            // 
            // lsbPostOrder
            // 
            lsbPostOrder.Font = new Font("Segoe UI", 12F);
            lsbPostOrder.FormattingEnabled = true;
            lsbPostOrder.ItemHeight = 28;
            lsbPostOrder.Location = new Point(405, 204);
            lsbPostOrder.Margin = new Padding(3, 4, 3, 4);
            lsbPostOrder.Name = "lsbPostOrder";
            lsbPostOrder.Size = new Size(234, 116);
            lsbPostOrder.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(405, 18);
            label5.Name = "label5";
            label5.Size = new Size(109, 26);
            label5.TabIndex = 30;
            label5.Text = "Preorder";
            // 
            // lsbPreorder
            // 
            lsbPreorder.Font = new Font("Segoe UI", 12F);
            lsbPreorder.FormattingEnabled = true;
            lsbPreorder.ItemHeight = 28;
            lsbPreorder.Location = new Point(405, 48);
            lsbPreorder.Margin = new Padding(3, 4, 3, 4);
            lsbPreorder.Name = "lsbPreorder";
            lsbPreorder.Size = new Size(234, 116);
            lsbPreorder.TabIndex = 29;
            // 
            // lblBinaryTree
            // 
            lblBinaryTree.AutoSize = true;
            lblBinaryTree.Font = new Font("Lucida Sans", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBinaryTree.Location = new Point(36, 31);
            lblBinaryTree.Name = "lblBinaryTree";
            lblBinaryTree.Size = new Size(183, 34);
            lblBinaryTree.TabIndex = 28;
            lblBinaryTree.Text = "Binary Tree";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(810, 191);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(159, 40);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(810, 123);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 26;
            label4.Text = "Number";
            // 
            // txtNumberBinaryTree
            // 
            txtNumberBinaryTree.ImeMode = ImeMode.NoControl;
            txtNumberBinaryTree.Location = new Point(810, 146);
            txtNumberBinaryTree.Name = "txtNumberBinaryTree";
            txtNumberBinaryTree.Size = new Size(253, 27);
            txtNumberBinaryTree.TabIndex = 25;
            // 
            // lsbBinaryTree
            // 
            lsbBinaryTree.Font = new Font("Segoe UI", 12F);
            lsbBinaryTree.FormattingEnabled = true;
            lsbBinaryTree.ItemHeight = 28;
            lsbBinaryTree.Location = new Point(36, 73);
            lsbBinaryTree.Margin = new Padding(3, 4, 3, 4);
            lsbBinaryTree.Name = "lsbBinaryTree";
            lsbBinaryTree.Size = new Size(340, 396);
            lsbBinaryTree.TabIndex = 15;
            // 
            // gbxCircularQLenght
            // 
            gbxCircularQLenght.Controls.Add(lblLenght);
            gbxCircularQLenght.Controls.Add(textBox1);
            gbxCircularQLenght.Location = new Point(102, 38);
            gbxCircularQLenght.Name = "gbxCircularQLenght";
            gbxCircularQLenght.Size = new Size(314, 74);
            gbxCircularQLenght.TabIndex = 36;
            gbxCircularQLenght.TabStop = false;
            // 
            // lblLenght
            // 
            lblLenght.AutoSize = true;
            lblLenght.Location = new Point(29, 18);
            lblLenght.Name = "lblLenght";
            lblLenght.Size = new Size(54, 20);
            lblLenght.TabIndex = 35;
            lblLenght.Text = "Lenght";
            // 
            // textBox1
            // 
            textBox1.ImeMode = ImeMode.NoControl;
            textBox1.Location = new Point(29, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 27);
            textBox1.TabIndex = 34;
            // 
            // gbxPriorityQue
            // 
            gbxPriorityQue.Controls.Add(label3);
            gbxPriorityQue.Controls.Add(txtPriorityQ);
            gbxPriorityQue.Location = new Point(99, 108);
            gbxPriorityQue.Name = "gbxPriorityQue";
            gbxPriorityQue.Size = new Size(324, 69);
            gbxPriorityQue.TabIndex = 33;
            gbxPriorityQue.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 10);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 32;
            label3.Text = "Priority";
            // 
            // txtPriorityQ
            // 
            txtPriorityQ.ImeMode = ImeMode.NoControl;
            txtPriorityQ.Location = new Point(32, 33);
            txtPriorityQ.Name = "txtPriorityQ";
            txtPriorityQ.Size = new Size(253, 27);
            txtPriorityQ.TabIndex = 31;
            // 
            // gbxCircularQ
            // 
            gbxCircularQ.Controls.Add(btnPeekQRear);
            gbxCircularQ.Controls.Add(btnDequeueRear);
            gbxCircularQ.Controls.Add(btnEnqueueRear);
            gbxCircularQ.Location = new Point(306, 237);
            gbxCircularQ.Name = "gbxCircularQ";
            gbxCircularQ.Size = new Size(187, 176);
            gbxCircularQ.TabIndex = 30;
            gbxCircularQ.TabStop = false;
            // 
            // btnPeekQRear
            // 
            btnPeekQRear.Location = new Point(6, 110);
            btnPeekQRear.Name = "btnPeekQRear";
            btnPeekQRear.Size = new Size(159, 40);
            btnPeekQRear.TabIndex = 29;
            btnPeekQRear.Text = "Peek rear";
            btnPeekQRear.UseCompatibleTextRendering = true;
            btnPeekQRear.UseVisualStyleBackColor = true;
            btnPeekQRear.Click += btnPeekQRear_Click;
            // 
            // btnDequeueRear
            // 
            btnDequeueRear.Location = new Point(6, 58);
            btnDequeueRear.Name = "btnDequeueRear";
            btnDequeueRear.Size = new Size(159, 40);
            btnDequeueRear.TabIndex = 27;
            btnDequeueRear.Text = "Dequeue rear";
            btnDequeueRear.UseVisualStyleBackColor = true;
            btnDequeueRear.Click += btnDequeueRear_Click;
            // 
            // btnEnqueueRear
            // 
            btnEnqueueRear.Location = new Point(6, 6);
            btnEnqueueRear.Name = "btnEnqueueRear";
            btnEnqueueRear.Size = new Size(159, 40);
            btnEnqueueRear.TabIndex = 25;
            btnEnqueueRear.Text = "Enqueue rear";
            btnEnqueueRear.UseVisualStyleBackColor = true;
            btnEnqueueRear.Click += btnEnqueueRear_Click;
            // 
            // btnPeekQ
            // 
            btnPeekQ.Location = new Point(131, 347);
            btnPeekQ.Name = "btnPeekQ";
            btnPeekQ.Size = new Size(159, 40);
            btnPeekQ.TabIndex = 28;
            btnPeekQ.Text = "Peek";
            btnPeekQ.UseVisualStyleBackColor = true;
            btnPeekQ.Click += btnPeekQ_Click;
            // 
            // btnDequeue
            // 
            btnDequeue.Location = new Point(131, 295);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(159, 40);
            btnDequeue.TabIndex = 26;
            btnDequeue.Text = "Dequeue";
            btnDequeue.UseVisualStyleBackColor = true;
            btnDequeue.Click += btnDequeue_Click;
            // 
            // btnEnqueue
            // 
            btnEnqueue.Location = new Point(131, 243);
            btnEnqueue.Name = "btnEnqueue";
            btnEnqueue.Size = new Size(159, 40);
            btnEnqueue.TabIndex = 24;
            btnEnqueue.Text = "Enqueue";
            btnEnqueue.UseVisualStyleBackColor = true;
            btnEnqueue.Click += btnEnqueue_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 175);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 23;
            label2.Text = "Number";
            // 
            // txtNumbersQueue
            // 
            txtNumbersQueue.ImeMode = ImeMode.NoControl;
            txtNumbersQueue.Location = new Point(131, 198);
            txtNumbersQueue.Name = "txtNumbersQueue";
            txtNumbersQueue.Size = new Size(253, 27);
            txtNumbersQueue.TabIndex = 22;
            // 
            // lsbQueues
            // 
            lsbQueues.Font = new Font("Segoe UI", 12F);
            lsbQueues.FormattingEnabled = true;
            lsbQueues.ItemHeight = 28;
            lsbQueues.Location = new Point(592, 62);
            lsbQueues.Margin = new Padding(3, 4, 3, 4);
            lsbQueues.Name = "lsbQueues";
            lsbQueues.Size = new Size(394, 340);
            lsbQueues.TabIndex = 14;
            // 
            // btnDeleteTreeN
            // 
            btnDeleteTreeN.Location = new Point(810, 237);
            btnDeleteTreeN.Name = "btnDeleteTreeN";
            btnDeleteTreeN.Size = new Size(159, 40);
            btnDeleteTreeN.TabIndex = 35;
            btnDeleteTreeN.Text = "Delete";
            btnDeleteTreeN.UseVisualStyleBackColor = true;
            // 
            // btnSearchTreeN
            // 
            btnSearchTreeN.Location = new Point(810, 283);
            btnSearchTreeN.Name = "btnSearchTreeN";
            btnSearchTreeN.Size = new Size(159, 40);
            btnSearchTreeN.TabIndex = 36;
            btnSearchTreeN.Text = "Search";
            btnSearchTreeN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1127, 527);
            Controls.Add(pnlQueues);
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
            pnlQueues.ResumeLayout(false);
            pnlQueues.PerformLayout();
            pnlTreeGraphic.ResumeLayout(false);
            pnlTreeGraphic.PerformLayout();
            gbxCircularQLenght.ResumeLayout(false);
            gbxCircularQLenght.PerformLayout();
            gbxPriorityQue.ResumeLayout(false);
            gbxPriorityQue.PerformLayout();
            gbxCircularQ.ResumeLayout(false);
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
        private Panel pnlQueues;
        private Button btnEnqueue;
        private Label label2;
        private TextBox txtNumbersQueue;
        private ListBox lsbQueues;
        private Button btnDequeue;
        private Button btnEnqueueRear;
        private Button btnDequeueRear;
        private Button btnPeekQ;
        private GroupBox gbxCircularQ;
        private Button btnPeekQRear;
        private Label label3;
        private TextBox txtPriorityQ;
        private ToolStripMenuItem regularQueueToolStripMenuItem;
        private ToolStripMenuItem doubleQueueToolStripMenuItem;
        private ToolStripMenuItem priorityQueueToolStripMenuItem;
        private ToolStripMenuItem circularQueueToolStripMenuItem;
        private GroupBox gbxPriorityQue;
        private Label lblLenght;
        private TextBox textBox1;
        private GroupBox gbxCircularQLenght;
        private Panel pnlTreeGraphic;
        private Button btnAdd;
        private Label label4;
        private TextBox txtNumberBinaryTree;
        private ListBox lsbBinaryTree;
        private Label lblBinaryTree;
        private Label label7;
        private ListBox InOrder;
        private Label label6;
        private ListBox lsbPostOrder;
        private Label label5;
        private ListBox lsbPreorder;
        private Button btnSearchTreeN;
        private Button btnDeleteTreeN;
    }
}
