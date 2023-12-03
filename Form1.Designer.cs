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
            panel1 = new Panel();
            btnGraphs = new Button();
            btnTrees = new Button();
            btnQueues = new Button();
            btnLists = new Button();
            btnStacks = new Button();
            lblBeggininMessage = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblBeggininMessage);
            panel1.Controls.Add(btnGraphs);
            panel1.Controls.Add(btnTrees);
            panel1.Controls.Add(btnQueues);
            panel1.Controls.Add(btnLists);
            panel1.Controls.Add(btnStacks);
            panel1.Location = new Point(8, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1107, 507);
            panel1.TabIndex = 0;
            // 
            // btnGraphs
            // 
            btnGraphs.FlatStyle = FlatStyle.System;
            btnGraphs.Location = new Point(466, 368);
            btnGraphs.Name = "btnGraphs";
            btnGraphs.Size = new Size(160, 41);
            btnGraphs.TabIndex = 4;
            btnGraphs.Text = "Graphs";
            btnGraphs.UseVisualStyleBackColor = true;
            // 
            // btnTrees
            // 
            btnTrees.FlatStyle = FlatStyle.System;
            btnTrees.Location = new Point(466, 321);
            btnTrees.Name = "btnTrees";
            btnTrees.Size = new Size(160, 41);
            btnTrees.TabIndex = 3;
            btnTrees.Text = "Trees";
            btnTrees.UseVisualStyleBackColor = true;
            // 
            // btnQueues
            // 
            btnQueues.FlatStyle = FlatStyle.System;
            btnQueues.Location = new Point(466, 274);
            btnQueues.Name = "btnQueues";
            btnQueues.Size = new Size(160, 41);
            btnQueues.TabIndex = 2;
            btnQueues.Text = "Queues";
            btnQueues.UseVisualStyleBackColor = true;
            // 
            // btnLists
            // 
            btnLists.FlatStyle = FlatStyle.System;
            btnLists.Location = new Point(466, 180);
            btnLists.Name = "btnLists";
            btnLists.Size = new Size(160, 41);
            btnLists.TabIndex = 0;
            btnLists.Text = "Lists";
            btnLists.UseVisualStyleBackColor = true;
            btnLists.Click += btnLists_Click;
            // 
            // btnStacks
            // 
            btnStacks.FlatStyle = FlatStyle.System;
            btnStacks.Location = new Point(466, 227);
            btnStacks.Name = "btnStacks";
            btnStacks.Size = new Size(160, 41);
            btnStacks.TabIndex = 1;
            btnStacks.Text = "Stacks";
            btnStacks.UseVisualStyleBackColor = true;
            // 
            // lblBeggininMessage
            // 
            lblBeggininMessage.AutoSize = true;
            lblBeggininMessage.Font = new Font("Yu Gothic UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBeggininMessage.Location = new Point(388, 94);
            lblBeggininMessage.Name = "lblBeggininMessage";
            lblBeggininMessage.Size = new Size(329, 60);
            lblBeggininMessage.TabIndex = 5;
            lblBeggininMessage.Text = "Data structures";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1127, 527);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLists;
        private Button btnQueues;
        private Button btnStacks;
        private Button btnGraphs;
        private Button btnTrees;
        private Label lblBeggininMessage;
    }
}
