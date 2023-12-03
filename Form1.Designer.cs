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
            btnGraphs = new Button();
            btnTrees = new Button();
            btnQueues = new Button();
            btnLists = new Button();
            btnStacks = new Button();
            SuspendLayout();
            // 
            // lblBeggininMessage
            // 
            lblBeggininMessage.AutoSize = true;
            lblBeggininMessage.Font = new Font("Yu Gothic UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBeggininMessage.Location = new Point(399, 106);
            lblBeggininMessage.Name = "lblBeggininMessage";
            lblBeggininMessage.Size = new Size(329, 60);
            lblBeggininMessage.TabIndex = 11;
            lblBeggininMessage.Text = "Data structures";
            // 
            // btnGraphs
            // 
            btnGraphs.FlatStyle = FlatStyle.System;
            btnGraphs.Location = new Point(477, 380);
            btnGraphs.Name = "btnGraphs";
            btnGraphs.Size = new Size(160, 41);
            btnGraphs.TabIndex = 10;
            btnGraphs.Text = "Graphs";
            btnGraphs.UseVisualStyleBackColor = true;
            // 
            // btnTrees
            // 
            btnTrees.FlatStyle = FlatStyle.System;
            btnTrees.Location = new Point(477, 333);
            btnTrees.Name = "btnTrees";
            btnTrees.Size = new Size(160, 41);
            btnTrees.TabIndex = 9;
            btnTrees.Text = "Trees";
            btnTrees.UseVisualStyleBackColor = true;
            // 
            // btnQueues
            // 
            btnQueues.FlatStyle = FlatStyle.System;
            btnQueues.Location = new Point(477, 286);
            btnQueues.Name = "btnQueues";
            btnQueues.Size = new Size(160, 41);
            btnQueues.TabIndex = 8;
            btnQueues.Text = "Queues";
            btnQueues.UseVisualStyleBackColor = true;
            // 
            // btnLists
            // 
            btnLists.FlatStyle = FlatStyle.System;
            btnLists.Location = new Point(477, 192);
            btnLists.Name = "btnLists";
            btnLists.Size = new Size(160, 41);
            btnLists.TabIndex = 6;
            btnLists.Text = "Lists";
            btnLists.UseVisualStyleBackColor = true;
            btnLists.Click += btnLists_Click;
            // 
            // btnStacks
            // 
            btnStacks.FlatStyle = FlatStyle.System;
            btnStacks.Location = new Point(477, 239);
            btnStacks.Name = "btnStacks";
            btnStacks.Size = new Size(160, 41);
            btnStacks.TabIndex = 7;
            btnStacks.Text = "Stacks";
            btnStacks.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1127, 527);
            Controls.Add(lblBeggininMessage);
            Controls.Add(btnGraphs);
            Controls.Add(btnTrees);
            Controls.Add(btnQueues);
            Controls.Add(btnLists);
            Controls.Add(btnStacks);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBeggininMessage;
        private Button btnGraphs;
        private Button btnTrees;
        private Button btnQueues;
        private Button btnLists;
        private Button btnStacks;
    }
}
