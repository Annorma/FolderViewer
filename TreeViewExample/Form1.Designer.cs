namespace TreeViewExample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Корневой узел 1", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Корневой узел 2", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Third Element");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(15, 15);
            this.treeView1.Margin = new System.Windows.Forms.Padding(6);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node5";
            treeNode1.Text = "Node5";
            treeNode2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            treeNode2.ForeColor = System.Drawing.Color.White;
            treeNode2.Name = "Node0";
            treeNode2.Text = "Корневой узел 1";
            treeNode3.Name = "Node4";
            treeNode3.Text = "Node4";
            treeNode4.Name = "Node3";
            treeNode4.Text = "Node3";
            treeNode5.Name = "Node2";
            treeNode5.Text = "Node2";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Node0";
            treeNode7.BackColor = System.Drawing.Color.Blue;
            treeNode7.ForeColor = System.Drawing.Color.Yellow;
            treeNode7.Name = "Node1";
            treeNode7.Text = "Корневой узел 2";
            treeNode8.Name = "Node1";
            treeNode8.Text = "Third Element";
            treeNode8.ToolTipText = "Push me";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode7,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(488, 465);
            this.treeView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 644);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Дерево просмотра";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}

