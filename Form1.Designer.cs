namespace FileCompare
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
            lblAppName = new Label();
            splitContainer1 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lvwLeftDir = new ListView();
            panel2 = new Panel();
            btnLeftDir = new Button();
            txtLeftDir = new TextBox();
            panel1 = new Panel();
            btnCopyFromLeft = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lvwRighrDir = new ListView();
            panel4 = new Panel();
            txtRightDir = new TextBox();
            btnRightDir = new Button();
            panel3 = new Panel();
            btnCopyFromRight = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = SystemColors.Highlight;
            lblAppName.Location = new Point(26, 16);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(471, 92);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "File Compare";
            lblAppName.Click += lblAppName_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 111);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel2);
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Size = new Size(1192, 607);
            splitContainer1.SplitterDistance = 596;
            splitContainer1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lvwLeftDir);
            flowLayoutPanel1.Location = new Point(14, 118);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(573, 464);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // lvwLeftDir
            // 
            lvwLeftDir.Location = new Point(3, 3);
            lvwLeftDir.Name = "lvwLeftDir";
            lvwLeftDir.Size = new Size(567, 464);
            lvwLeftDir.TabIndex = 6;
            lvwLeftDir.UseCompatibleStateImageBehavior = false;
            lvwLeftDir.SelectedIndexChanged += lvwLeftDir_SelectedIndexChanged_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLeftDir);
            panel2.Controls.Add(txtLeftDir);
            panel2.Location = new Point(20, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(567, 53);
            panel2.TabIndex = 6;
            // 
            // btnLeftDir
            // 
            btnLeftDir.Font = new Font("맑은 고딕", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnLeftDir.Location = new Point(451, 3);
            btnLeftDir.Name = "btnLeftDir";
            btnLeftDir.Size = new Size(116, 39);
            btnLeftDir.TabIndex = 3;
            btnLeftDir.Text = "찾아보기";
            btnLeftDir.UseVisualStyleBackColor = true;
            btnLeftDir.Click += btnLeftDir_Click;
            // 
            // txtLeftDir
            // 
            txtLeftDir.Location = new Point(3, 3);
            txtLeftDir.Name = "txtLeftDir";
            txtLeftDir.Size = new Size(448, 39);
            txtLeftDir.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCopyFromLeft);
            panel1.Location = new Point(23, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 45);
            panel1.TabIndex = 2;
            // 
            // btnCopyFromLeft
            // 
            btnCopyFromLeft.Location = new Point(451, 0);
            btnCopyFromLeft.Name = "btnCopyFromLeft";
            btnCopyFromLeft.Size = new Size(113, 43);
            btnCopyFromLeft.TabIndex = 5;
            btnCopyFromLeft.Text = ">>>";
            btnCopyFromLeft.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lvwRighrDir);
            flowLayoutPanel2.Location = new Point(17, 121);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(587, 497);
            flowLayoutPanel2.TabIndex = 9;
            // 
            // lvwRighrDir
            // 
            lvwRighrDir.Location = new Point(3, 3);
            lvwRighrDir.Name = "lvwRighrDir";
            lvwRighrDir.Size = new Size(567, 464);
            lvwRighrDir.TabIndex = 6;
            lvwRighrDir.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtRightDir);
            panel4.Controls.Add(btnRightDir);
            panel4.Location = new Point(17, 57);
            panel4.Name = "panel4";
            panel4.Size = new Size(567, 57);
            panel4.TabIndex = 8;
            // 
            // txtRightDir
            // 
            txtRightDir.Location = new Point(3, 8);
            txtRightDir.Name = "txtRightDir";
            txtRightDir.Size = new Size(448, 39);
            txtRightDir.TabIndex = 1;
            txtRightDir.TextChanged += txtRightDir_TextChanged;
            // 
            // btnRightDir
            // 
            btnRightDir.Font = new Font("맑은 고딕", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnRightDir.Location = new Point(451, 8);
            btnRightDir.Name = "btnRightDir";
            btnRightDir.Size = new Size(116, 39);
            btnRightDir.TabIndex = 3;
            btnRightDir.Text = "찾아보기";
            btnRightDir.UseVisualStyleBackColor = true;
            btnRightDir.Click += btnRightDir_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCopyFromRight);
            panel3.Location = new Point(17, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(587, 49);
            panel3.TabIndex = 7;
            // 
            // btnCopyFromRight
            // 
            btnCopyFromRight.Location = new Point(3, 2);
            btnCopyFromRight.Name = "btnCopyFromRight";
            btnCopyFromRight.Size = new Size(113, 43);
            btnCopyFromRight.TabIndex = 5;
            btnCopyFromRight.Text = "<<<";
            btnCopyFromRight.UseVisualStyleBackColor = true;
            btnCopyFromRight.Click += btnCopyFromRight_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 730);
            Controls.Add(splitContainer1);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "File Compare";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private SplitContainer splitContainer1;
        private Button btnCopyFromRight;
        private Button btnRightDir;
        private TextBox txtRightDir;
        private ListView lvwRighrDir;
        private Panel panel2;
        private Button btnLeftDir;
        private TextBox txtLeftDir;
        private Panel panel1;
        private Button btnCopyFromLeft;
        private FlowLayoutPanel flowLayoutPanel1;
        private ListView lvwLeftDir;
        private Panel panel4;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}
