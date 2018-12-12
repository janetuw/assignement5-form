namespace WindowsFormsApp11
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("number");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("student", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("code");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("room", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("calculator");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("utilities", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.work = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // work
            // 
            this.work.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.work.Location = new System.Drawing.Point(261, 3);
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(542, 445);
            this.work.TabIndex = 0;
            this.work.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "";
            treeNode2.Name = "Node2";
            treeNode2.Text = "number";
            treeNode3.Name = "Node1";
            treeNode3.Text = "student";
            treeNode4.Name = "Node4";
            treeNode4.Text = "code";
            treeNode5.Name = "Node3";
            treeNode5.Text = "room";
            treeNode6.Name = "Node6";
            treeNode6.Text = "calculator";
            treeNode7.Name = "Node5";
            treeNode7.Text = "utilities";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3,
            treeNode5,
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(252, 435);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.Click += new System.EventHandler(this.number);
            this.treeView1.DoubleClick += new System.EventHandler(this.calculator);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.work);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel work;
        private System.Windows.Forms.TreeView treeView1;
    }
}

