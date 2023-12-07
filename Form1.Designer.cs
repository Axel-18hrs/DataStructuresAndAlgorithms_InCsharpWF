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
            gbxCircularQLenght = new GroupBox();
            btnStartQu = new Button();
            lblLenght = new Label();
            txtLenghtsQu = new TextBox();
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
            pnlTree = new Panel();
            treeView = new TreeView();
            btnSearchTreeN = new Button();
            btnDeleteTreeN = new Button();
            label7 = new Label();
            lsbInOrder = new ListBox();
            label6 = new Label();
            lsbPostOrder = new ListBox();
            label5 = new Label();
            lsbPreorder = new ListBox();
            lblBinaryTree = new Label();
            btnAdd = new Button();
            label4 = new Label();
            txtNumberBinaryTree = new TextBox();
            pnlGraph = new Panel();
            btnFindAwayGraph = new Button();
            btnToursDFSGraph = new Button();
            btnAddEdgeGraph = new Button();
            btnDeleteGraph = new Button();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            txtOriginGraph = new TextBox();
            label11 = new Label();
            txtWeightGraph = new TextBox();
            label10 = new Label();
            txtDestinationGraph = new TextBox();
            lsbTourGraph = new ListBox();
            lsbAdyacencyMatrixGraph = new ListBox();
            btnAddVertGraph = new Button();
            label9 = new Label();
            txtNumberGraph = new TextBox();
            label8 = new Label();
            lsbGraph = new ListBox();
            menuStrip1.SuspendLayout();
            pnlLists.SuspendLayout();
            pnlStacks.SuspendLayout();
            gbxMenuStackAll.SuspendLayout();
            gbxMenuStatickStack.SuspendLayout();
            pnlQueues.SuspendLayout();
            gbxCircularQLenght.SuspendLayout();
            gbxPriorityQue.SuspendLayout();
            gbxCircularQ.SuspendLayout();
            pnlTree.SuspendLayout();
            pnlGraph.SuspendLayout();
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
            graphsToolStripMenuItem.Click += graphsToolStripMenuItem_Click;
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
            // gbxCircularQLenght
            // 
            gbxCircularQLenght.Controls.Add(btnStartQu);
            gbxCircularQLenght.Controls.Add(lblLenght);
            gbxCircularQLenght.Controls.Add(txtLenghtsQu);
            gbxCircularQLenght.Location = new Point(102, 38);
            gbxCircularQLenght.Name = "gbxCircularQLenght";
            gbxCircularQLenght.Size = new Size(314, 128);
            gbxCircularQLenght.TabIndex = 36;
            gbxCircularQLenght.TabStop = false;
            // 
            // btnStartQu
            // 
            btnStartQu.Location = new Point(29, 74);
            btnStartQu.Name = "btnStartQu";
            btnStartQu.Size = new Size(159, 40);
            btnStartQu.TabIndex = 37;
            btnStartQu.Text = "Start";
            btnStartQu.UseVisualStyleBackColor = true;
            btnStartQu.Click += btnStartQu_Click;
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
            // txtLenghtsQu
            // 
            txtLenghtsQu.ImeMode = ImeMode.NoControl;
            txtLenghtsQu.Location = new Point(29, 41);
            txtLenghtsQu.Name = "txtLenghtsQu";
            txtLenghtsQu.Size = new Size(253, 27);
            txtLenghtsQu.TabIndex = 34;
            // 
            // gbxPriorityQue
            // 
            gbxPriorityQue.Controls.Add(label3);
            gbxPriorityQue.Controls.Add(txtPriorityQ);
            gbxPriorityQue.Location = new Point(99, 172);
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
            gbxCircularQ.Location = new Point(306, 301);
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
            btnPeekQ.Location = new Point(131, 411);
            btnPeekQ.Name = "btnPeekQ";
            btnPeekQ.Size = new Size(159, 40);
            btnPeekQ.TabIndex = 28;
            btnPeekQ.Text = "Peek";
            btnPeekQ.UseVisualStyleBackColor = true;
            btnPeekQ.Click += btnPeekQ_Click;
            // 
            // btnDequeue
            // 
            btnDequeue.Location = new Point(131, 359);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(159, 40);
            btnDequeue.TabIndex = 26;
            btnDequeue.Text = "Dequeue";
            btnDequeue.UseVisualStyleBackColor = true;
            btnDequeue.Click += btnDequeue_Click;
            // 
            // btnEnqueue
            // 
            btnEnqueue.Location = new Point(131, 307);
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
            label2.Location = new Point(131, 239);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 23;
            label2.Text = "Number";
            // 
            // txtNumbersQueue
            // 
            txtNumbersQueue.ImeMode = ImeMode.NoControl;
            txtNumbersQueue.Location = new Point(131, 262);
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
            // pnlTree
            // 
            pnlTree.Controls.Add(treeView);
            pnlTree.Controls.Add(btnSearchTreeN);
            pnlTree.Controls.Add(btnDeleteTreeN);
            pnlTree.Controls.Add(label7);
            pnlTree.Controls.Add(lsbInOrder);
            pnlTree.Controls.Add(label6);
            pnlTree.Controls.Add(lsbPostOrder);
            pnlTree.Controls.Add(label5);
            pnlTree.Controls.Add(lsbPreorder);
            pnlTree.Controls.Add(lblBinaryTree);
            pnlTree.Controls.Add(btnAdd);
            pnlTree.Controls.Add(label4);
            pnlTree.Controls.Add(txtNumberBinaryTree);
            pnlTree.Location = new Point(0, 31);
            pnlTree.Name = "pnlTree";
            pnlTree.Size = new Size(1134, 498);
            pnlTree.TabIndex = 16;
            pnlTree.Paint += pnlTree_Paint;
            // 
            // treeView
            // 
            treeView.AllowDrop = true;
            treeView.Location = new Point(54, 68);
            treeView.Name = "treeView";
            treeView.Size = new Size(318, 409);
            treeView.TabIndex = 50;
            // 
            // btnSearchTreeN
            // 
            btnSearchTreeN.Location = new Point(743, 279);
            btnSearchTreeN.Name = "btnSearchTreeN";
            btnSearchTreeN.Size = new Size(159, 40);
            btnSearchTreeN.TabIndex = 49;
            btnSearchTreeN.Text = "Search";
            btnSearchTreeN.UseVisualStyleBackColor = true;
            btnSearchTreeN.Click += btnSearchTreeN_Click;
            // 
            // btnDeleteTreeN
            // 
            btnDeleteTreeN.Location = new Point(743, 233);
            btnDeleteTreeN.Name = "btnDeleteTreeN";
            btnDeleteTreeN.Size = new Size(159, 40);
            btnDeleteTreeN.TabIndex = 48;
            btnDeleteTreeN.Text = "Delete";
            btnDeleteTreeN.UseVisualStyleBackColor = true;
            btnDeleteTreeN.Click += btnDeleteTreeN_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(423, 337);
            label7.Name = "label7";
            label7.Size = new Size(101, 26);
            label7.TabIndex = 47;
            label7.Text = "InOrder";
            // 
            // lsbInOrder
            // 
            lsbInOrder.Font = new Font("Segoe UI", 12F);
            lsbInOrder.FormattingEnabled = true;
            lsbInOrder.ItemHeight = 28;
            lsbInOrder.Location = new Point(423, 367);
            lsbInOrder.Margin = new Padding(3, 4, 3, 4);
            lsbInOrder.Name = "lsbInOrder";
            lsbInOrder.Size = new Size(234, 116);
            lsbInOrder.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(423, 170);
            label6.Name = "label6";
            label6.Size = new Size(124, 26);
            label6.TabIndex = 45;
            label6.Text = "PostOrder";
            // 
            // lsbPostOrder
            // 
            lsbPostOrder.Font = new Font("Segoe UI", 12F);
            lsbPostOrder.FormattingEnabled = true;
            lsbPostOrder.ItemHeight = 28;
            lsbPostOrder.Location = new Point(423, 200);
            lsbPostOrder.Margin = new Padding(3, 4, 3, 4);
            lsbPostOrder.Name = "lsbPostOrder";
            lsbPostOrder.Size = new Size(234, 116);
            lsbPostOrder.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(423, 14);
            label5.Name = "label5";
            label5.Size = new Size(109, 26);
            label5.TabIndex = 43;
            label5.Text = "Preorder";
            // 
            // lsbPreorder
            // 
            lsbPreorder.Font = new Font("Segoe UI", 12F);
            lsbPreorder.FormattingEnabled = true;
            lsbPreorder.ItemHeight = 28;
            lsbPreorder.Location = new Point(423, 44);
            lsbPreorder.Margin = new Padding(3, 4, 3, 4);
            lsbPreorder.Name = "lsbPreorder";
            lsbPreorder.Size = new Size(234, 116);
            lsbPreorder.TabIndex = 42;
            // 
            // lblBinaryTree
            // 
            lblBinaryTree.AutoSize = true;
            lblBinaryTree.Font = new Font("Lucida Sans", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBinaryTree.Location = new Point(54, 27);
            lblBinaryTree.Name = "lblBinaryTree";
            lblBinaryTree.Size = new Size(183, 34);
            lblBinaryTree.TabIndex = 41;
            lblBinaryTree.Text = "Binary Tree";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(743, 187);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(159, 40);
            btnAdd.TabIndex = 40;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(743, 119);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 39;
            label4.Text = "Number";
            // 
            // txtNumberBinaryTree
            // 
            txtNumberBinaryTree.ImeMode = ImeMode.NoControl;
            txtNumberBinaryTree.Location = new Point(743, 142);
            txtNumberBinaryTree.Name = "txtNumberBinaryTree";
            txtNumberBinaryTree.Size = new Size(253, 27);
            txtNumberBinaryTree.TabIndex = 38;
            // 
            // pnlGraph
            // 
            pnlGraph.Controls.Add(btnFindAwayGraph);
            pnlGraph.Controls.Add(btnToursDFSGraph);
            pnlGraph.Controls.Add(btnAddEdgeGraph);
            pnlGraph.Controls.Add(btnDeleteGraph);
            pnlGraph.Controls.Add(label14);
            pnlGraph.Controls.Add(label13);
            pnlGraph.Controls.Add(label12);
            pnlGraph.Controls.Add(txtOriginGraph);
            pnlGraph.Controls.Add(label11);
            pnlGraph.Controls.Add(txtWeightGraph);
            pnlGraph.Controls.Add(label10);
            pnlGraph.Controls.Add(txtDestinationGraph);
            pnlGraph.Controls.Add(lsbTourGraph);
            pnlGraph.Controls.Add(lsbAdyacencyMatrixGraph);
            pnlGraph.Controls.Add(btnAddVertGraph);
            pnlGraph.Controls.Add(label9);
            pnlGraph.Controls.Add(txtNumberGraph);
            pnlGraph.Controls.Add(label8);
            pnlGraph.Controls.Add(lsbGraph);
            pnlGraph.Location = new Point(0, 31);
            pnlGraph.Name = "pnlGraph";
            pnlGraph.Size = new Size(1133, 495);
            pnlGraph.TabIndex = 17;
            pnlGraph.Paint += panel1_Paint;
            // 
            // btnFindAwayGraph
            // 
            btnFindAwayGraph.Location = new Point(565, 46);
            btnFindAwayGraph.Name = "btnFindAwayGraph";
            btnFindAwayGraph.Size = new Size(159, 40);
            btnFindAwayGraph.TabIndex = 62;
            btnFindAwayGraph.Text = "Find way";
            btnFindAwayGraph.UseVisualStyleBackColor = true;
            btnFindAwayGraph.Click += btnFindAwayGraph_Click;
            // 
            // btnToursDFSGraph
            // 
            btnToursDFSGraph.Location = new Point(471, 101);
            btnToursDFSGraph.Name = "btnToursDFSGraph";
            btnToursDFSGraph.Size = new Size(159, 40);
            btnToursDFSGraph.TabIndex = 61;
            btnToursDFSGraph.Text = "Tours DFS";
            btnToursDFSGraph.UseVisualStyleBackColor = true;
            btnToursDFSGraph.Click += btnToursDFSGraph_Click;
            // 
            // btnAddEdgeGraph
            // 
            btnAddEdgeGraph.Location = new Point(306, 101);
            btnAddEdgeGraph.Name = "btnAddEdgeGraph";
            btnAddEdgeGraph.Size = new Size(159, 40);
            btnAddEdgeGraph.TabIndex = 60;
            btnAddEdgeGraph.Text = "Add edge";
            btnAddEdgeGraph.UseVisualStyleBackColor = true;
            btnAddEdgeGraph.Click += btnAddEdgeGraph_Click;
            // 
            // btnDeleteGraph
            // 
            btnDeleteGraph.Location = new Point(935, 89);
            btnDeleteGraph.Name = "btnDeleteGraph";
            btnDeleteGraph.Size = new Size(159, 40);
            btnDeleteGraph.TabIndex = 59;
            btnDeleteGraph.Text = "Delete";
            btnDeleteGraph.UseVisualStyleBackColor = true;
            btnDeleteGraph.Click += btnDeleteGraph_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(810, 175);
            label14.Name = "label14";
            label14.Size = new Size(108, 26);
            label14.TabIndex = 58;
            label14.Text = "DFS tour";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(29, 175);
            label13.Name = "label13";
            label13.Size = new Size(83, 26);
            label13.TabIndex = 57;
            label13.Text = "Graph";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(306, 33);
            label12.Name = "label12";
            label12.Size = new Size(50, 20);
            label12.TabIndex = 56;
            label12.Text = "Origin";
            // 
            // txtOriginGraph
            // 
            txtOriginGraph.ImeMode = ImeMode.NoControl;
            txtOriginGraph.Location = new Point(306, 56);
            txtOriginGraph.Name = "txtOriginGraph";
            txtOriginGraph.Size = new Size(253, 27);
            txtOriginGraph.TabIndex = 55;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(29, 89);
            label11.Name = "label11";
            label11.Size = new Size(56, 20);
            label11.TabIndex = 54;
            label11.Text = "Weight";
            // 
            // txtWeightGraph
            // 
            txtWeightGraph.ImeMode = ImeMode.NoControl;
            txtWeightGraph.Location = new Point(29, 112);
            txtWeightGraph.Name = "txtWeightGraph";
            txtWeightGraph.Size = new Size(253, 27);
            txtWeightGraph.TabIndex = 53;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 33);
            label10.Name = "label10";
            label10.Size = new Size(85, 20);
            label10.TabIndex = 52;
            label10.Text = "Destination";
            // 
            // txtDestinationGraph
            // 
            txtDestinationGraph.ImeMode = ImeMode.NoControl;
            txtDestinationGraph.Location = new Point(29, 56);
            txtDestinationGraph.Name = "txtDestinationGraph";
            txtDestinationGraph.Size = new Size(253, 27);
            txtDestinationGraph.TabIndex = 51;
            // 
            // lsbTourGraph
            // 
            lsbTourGraph.Font = new Font("Segoe UI", 12F);
            lsbTourGraph.FormattingEnabled = true;
            lsbTourGraph.ItemHeight = 28;
            lsbTourGraph.Location = new Point(810, 203);
            lsbTourGraph.Margin = new Padding(3, 4, 3, 4);
            lsbTourGraph.Name = "lsbTourGraph";
            lsbTourGraph.Size = new Size(295, 284);
            lsbTourGraph.TabIndex = 50;
            // 
            // lsbAdyacencyMatrixGraph
            // 
            lsbAdyacencyMatrixGraph.Font = new Font("Segoe UI", 12F);
            lsbAdyacencyMatrixGraph.FormattingEnabled = true;
            lsbAdyacencyMatrixGraph.ItemHeight = 28;
            lsbAdyacencyMatrixGraph.Location = new Point(368, 203);
            lsbAdyacencyMatrixGraph.Margin = new Padding(3, 4, 3, 4);
            lsbAdyacencyMatrixGraph.Name = "lsbAdyacencyMatrixGraph";
            lsbAdyacencyMatrixGraph.Size = new Size(391, 284);
            lsbAdyacencyMatrixGraph.TabIndex = 49;
            // 
            // btnAddVertGraph
            // 
            btnAddVertGraph.Location = new Point(770, 89);
            btnAddVertGraph.Name = "btnAddVertGraph";
            btnAddVertGraph.Size = new Size(159, 40);
            btnAddVertGraph.TabIndex = 48;
            btnAddVertGraph.Text = "Add";
            btnAddVertGraph.UseVisualStyleBackColor = true;
            btnAddVertGraph.Click += btnAddVertGraph_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(770, 33);
            label9.Name = "label9";
            label9.Size = new Size(63, 20);
            label9.TabIndex = 47;
            label9.Text = "Number";
            // 
            // txtNumberGraph
            // 
            txtNumberGraph.ImeMode = ImeMode.NoControl;
            txtNumberGraph.Location = new Point(770, 56);
            txtNumberGraph.Name = "txtNumberGraph";
            txtNumberGraph.Size = new Size(253, 27);
            txtNumberGraph.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(368, 175);
            label8.Name = "label8";
            label8.Size = new Size(207, 26);
            label8.TabIndex = 45;
            label8.Text = "Adjacency matrix";
            // 
            // lsbGraph
            // 
            lsbGraph.Font = new Font("Segoe UI", 12F);
            lsbGraph.FormattingEnabled = true;
            lsbGraph.ItemHeight = 28;
            lsbGraph.Location = new Point(29, 203);
            lsbGraph.Margin = new Padding(3, 4, 3, 4);
            lsbGraph.Name = "lsbGraph";
            lsbGraph.Size = new Size(295, 284);
            lsbGraph.TabIndex = 44;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1127, 527);
            Controls.Add(pnlGraph);
            Controls.Add(pnlTree);
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
            gbxCircularQLenght.ResumeLayout(false);
            gbxCircularQLenght.PerformLayout();
            gbxPriorityQue.ResumeLayout(false);
            gbxPriorityQue.PerformLayout();
            gbxCircularQ.ResumeLayout(false);
            pnlTree.ResumeLayout(false);
            pnlTree.PerformLayout();
            pnlGraph.ResumeLayout(false);
            pnlGraph.PerformLayout();
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
        private TextBox txtLenghtsQu;
        private GroupBox gbxCircularQLenght;
        private Panel pnlTree;
        private Button btnSearchTreeN;
        private Button btnDeleteTreeN;
        private Label label7;
        private ListBox lsbInOrder;
        private Label label6;
        private ListBox lsbPostOrder;
        private Label label5;
        private ListBox lsbPreorder;
        private Label lblBinaryTree;
        private Button btnAdd;
        private Label label4;
        private TextBox txtNumberBinaryTree;
        private TreeView treeView;
        private Panel pnlGraph;
        private ListBox lsbTourGraph;
        private ListBox lsbAdyacencyMatrixGraph;
        private Button btnAddVertGraph;
        private Label label9;
        private TextBox txtNumberGraph;
        private Label label8;
        private ListBox lsbGraph;
        private Label label10;
        private TextBox txtDestinationGraph;
        private Label label11;
        private TextBox txtWeightGraph;
        private Label label12;
        private TextBox txtOriginGraph;
        private Label label14;
        private Label label13;
        private Button btnFindAwayGraph;
        private Button btnToursDFSGraph;
        private Button btnAddEdgeGraph;
        private Button btnDeleteGraph;
        private Button btnStartQu;
    }
}
