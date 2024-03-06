using System.ComponentModel;

namespace SerializationCSharp
{
    partial class Workspace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workspace));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Shops");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Workers");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Goods");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Content");
            this.picture = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.saveItemTool = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemTool = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTool = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.addShopTool = new System.Windows.Forms.ToolStripMenuItem();
            this.addWorkerTool = new System.Windows.Forms.ToolStripMenuItem();
            this.addGoodTool = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(12, 13);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(144, 122);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileTool, this.exitTool });
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileTool
            // 
            this.fileTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.saveItemTool, this.addItemTool });
            this.fileTool.Name = "fileTool";
            this.fileTool.Size = new System.Drawing.Size(37, 20);
            this.fileTool.Text = "File";
            // 
            // saveItemTool
            // 
            this.saveItemTool.Name = "saveItemTool";
            this.saveItemTool.Size = new System.Drawing.Size(152, 22);
            this.saveItemTool.Text = "Save Item";
            // 
            // addItemTool
            // 
            this.addItemTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.addShopTool, this.addWorkerTool, this.addGoodTool });
            this.addItemTool.Name = "addItemTool";
            this.addItemTool.Size = new System.Drawing.Size(152, 22);
            this.addItemTool.Text = "Add Item";
            // 
            // exitTool
            // 
            this.exitTool.Name = "exitTool";
            this.exitTool.Size = new System.Drawing.Size(38, 20);
            this.exitTool.Text = "Exit";
            this.exitTool.Click += new System.EventHandler(this.exitTool_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.picture);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treeView2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 425);
            this.splitContainer1.SplitterDistance = 171;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeView1.Location = new System.Drawing.Point(12, 141);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Shops";
            treeNode1.Text = "Shops";
            treeNode2.Name = "Workers";
            treeNode2.Text = "Workers";
            treeNode3.Name = "Goods";
            treeNode3.Text = "Goods";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNode1, treeNode2, treeNode3 });
            this.treeView1.Size = new System.Drawing.Size(144, 272);
            this.treeView1.TabIndex = 1;
            // 
            // treeView2
            // 
            this.treeView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView2.ItemHeight = 16;
            this.treeView2.Location = new System.Drawing.Point(13, 13);
            this.treeView2.Name = "treeView2";
            treeNode4.Name = "Content";
            treeNode4.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode4.Text = "Content";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNode4 });
            this.treeView2.Size = new System.Drawing.Size(600, 400);
            this.treeView2.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "object";
            this.openFileDialog.Filter = "Xml files(*.xml)|*.xml|JSON files(*.json)|*.json|All files(*.*)|*.*";
            // 
            // addShopTool
            // 
            this.addShopTool.Name = "addShopTool";
            this.addShopTool.Size = new System.Drawing.Size(152, 22);
            this.addShopTool.Text = "Add a shop";
            // 
            // addWorkerTool
            // 
            this.addWorkerTool.Name = "addWorkerTool";
            this.addWorkerTool.Size = new System.Drawing.Size(152, 22);
            this.addWorkerTool.Text = "Add a worker";
            // 
            // addGoodTool
            // 
            this.addGoodTool.Name = "addGoodTool";
            this.addGoodTool.Size = new System.Drawing.Size(152, 22);
            this.addGoodTool.Text = "Add a good";
            // 
            // Workspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Workspace";
            this.Text = "Workspace";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem addShopTool;
        private System.Windows.Forms.ToolStripMenuItem addWorkerTool;
        private System.Windows.Forms.ToolStripMenuItem addGoodTool;

        private System.Windows.Forms.OpenFileDialog openFileDialog;

        private System.Windows.Forms.TreeView treeView2;

        private System.Windows.Forms.TreeView treeView1;

        private System.Windows.Forms.ToolStripMenuItem fileTool;
        private System.Windows.Forms.ToolStripMenuItem saveItemTool;
        private System.Windows.Forms.ToolStripMenuItem addItemTool;
        private System.Windows.Forms.ToolStripMenuItem exitTool;

        private System.Windows.Forms.SplitContainer splitContainer1;

        private System.Windows.Forms.MenuStrip menuStrip;

        private System.Windows.Forms.PictureBox picture;

        #endregion
    }
}