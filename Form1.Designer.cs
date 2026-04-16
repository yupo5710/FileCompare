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
            flowLayoutPanel1 = new Panel();
            lvwLeftDir = new ListView();
            lvwLeftDirName = new ColumnHeader();
            lvwLeftDirSize = new ColumnHeader();
            lvwLeftDirDay = new ColumnHeader();
            panel2 = new Panel();
            btnLeftDir = new Button();
            txtLeftDir = new TextBox();
            panel1 = new Panel();
            btnCopyFromLeft = new Button();
            flowLayoutPanel2 = new Panel();
            lvwRightDir = new ListView();
            lvwRightDirName = new ColumnHeader();
            lvwRightDirSize = new ColumnHeader();
            lvwRightDirDay = new ColumnHeader();
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
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(12, 111);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
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
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 98);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(596, 509);
            flowLayoutPanel1.TabIndex = 7;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // lvwLeftDir
            // 
            lvwLeftDir.Columns.AddRange(new ColumnHeader[] { lvwLeftDirName, lvwLeftDirSize, lvwLeftDirDay });
            lvwLeftDir.Dock = DockStyle.Fill;
            lvwLeftDir.FullRowSelect = true;
            lvwLeftDir.GridLines = true;
            lvwLeftDir.Location = new Point(0, 0);
            lvwLeftDir.Name = "lvwLeftDir";
            lvwLeftDir.Size = new Size(596, 509);
            lvwLeftDir.TabIndex = 6;
            lvwLeftDir.UseCompatibleStateImageBehavior = false;
            lvwLeftDir.View = View.Details;
            lvwLeftDir.SelectedIndexChanged += lvwLeftDir_SelectedIndexChanged_1;
            // 
            // lvwLeftDirName
            // 
            lvwLeftDirName.Text = "이름";
            lvwLeftDirName.Width = 300;
            // 
            // lvwLeftDirSize
            // 
            lvwLeftDirSize.Text = "크기";
            lvwLeftDirSize.Width = 100;
            // 
            // lvwLeftDirDay
            // 
            lvwLeftDirDay.Text = "수정일";
            lvwLeftDirDay.Width = 160;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLeftDir);
            panel2.Controls.Add(txtLeftDir);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(596, 53);
            panel2.TabIndex = 6;
            // 
            // btnLeftDir
            // 
            btnLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLeftDir.Font = new Font("맑은 고딕", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnLeftDir.Location = new Point(478, 3);
            btnLeftDir.Name = "btnLeftDir";
            btnLeftDir.Size = new Size(115, 42);
            btnLeftDir.TabIndex = 3;
            btnLeftDir.Text = "찾아보기";
            btnLeftDir.UseVisualStyleBackColor = true;
            btnLeftDir.Click += btnLeftDir_Click;
            // 
            // txtLeftDir
            // 
            txtLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLeftDir.Location = new Point(3, 3);
            txtLeftDir.Name = "txtLeftDir";
            txtLeftDir.Size = new Size(448, 39);
            txtLeftDir.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCopyFromLeft);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 45);
            panel1.TabIndex = 2;
            // 
            // btnCopyFromLeft
            // 
            btnCopyFromLeft.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCopyFromLeft.Location = new Point(451, 0);
            btnCopyFromLeft.Name = "btnCopyFromLeft";
            btnCopyFromLeft.Size = new Size(142, 43);
            btnCopyFromLeft.TabIndex = 5;
            btnCopyFromLeft.Text = ">>>";
            btnCopyFromLeft.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lvwRightDir);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 106);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(592, 501);
            flowLayoutPanel2.TabIndex = 9;
            // 
            // lvwRightDir
            // 
            lvwRightDir.Columns.AddRange(new ColumnHeader[] { lvwRightDirName, lvwRightDirSize, lvwRightDirDay });
            lvwRightDir.Dock = DockStyle.Fill;
            lvwRightDir.FullRowSelect = true;
            lvwRightDir.GridLines = true;
            lvwRightDir.Location = new Point(0, 0);
            lvwRightDir.Name = "lvwRightDir";
            lvwRightDir.Size = new Size(592, 501);
            lvwRightDir.TabIndex = 6;
            lvwRightDir.UseCompatibleStateImageBehavior = false;
            lvwRightDir.View = View.Details;
            // 
            // lvwRightDirName
            // 
            lvwRightDirName.Text = "이름";
            lvwRightDirName.Width = 300;
            // 
            // lvwRightDirSize
            // 
            lvwRightDirSize.Text = "사이즈";
            lvwRightDirSize.Width = 100;
            // 
            // lvwRightDirDay
            // 
            lvwRightDirDay.Text = "수정일";
            lvwRightDirDay.Width = 160;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtRightDir);
            panel4.Controls.Add(btnRightDir);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 49);
            panel4.Name = "panel4";
            panel4.Size = new Size(592, 57);
            panel4.TabIndex = 8;
            // 
            // txtRightDir
            // 
            txtRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRightDir.Location = new Point(3, 8);
            txtRightDir.Name = "txtRightDir";
            txtRightDir.Size = new Size(448, 39);
            txtRightDir.TabIndex = 1;
            txtRightDir.TextChanged += txtRightDir_TextChanged;
            // 
            // btnRightDir
            // 
            btnRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRightDir.Font = new Font("맑은 고딕", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnRightDir.Location = new Point(482, 6);
            btnRightDir.Name = "btnRightDir";
            btnRightDir.Size = new Size(110, 41);
            btnRightDir.TabIndex = 3;
            btnRightDir.Text = "찾아보기";
            btnRightDir.UseVisualStyleBackColor = true;
            btnRightDir.Click += btnRightDir_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCopyFromRight);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(592, 49);
            panel3.TabIndex = 7;
            // 
            // btnCopyFromRight
            // 
            btnCopyFromRight.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnCopyFromRight.Location = new Point(3, 2);
            btnCopyFromRight.Name = "btnCopyFromRight";
            btnCopyFromRight.Size = new Size(118, 43);
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
        private ListView lvwRightDir;
        private Panel panel2;
        private Button btnLeftDir;
        private TextBox txtLeftDir;
        private Panel panel1;
        private Button btnCopyFromLeft;
        private Panel flowLayoutPanel1;
        private ListView lvwLeftDir;
        private Panel panel4;
        private Panel panel3;
        private Panel flowLayoutPanel2;
        private ColumnHeader lvwLeftDirName;
        private ColumnHeader lvwLeftDirSize;
        private ColumnHeader lvwLeftDirDay;
        private ColumnHeader lvwRightDirName;
        private ColumnHeader lvwRightDirSize;
        private ColumnHeader lvwRightDirDay;
    }
}
