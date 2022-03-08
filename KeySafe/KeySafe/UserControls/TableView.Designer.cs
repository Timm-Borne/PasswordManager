
namespace KeySafe.UserControls
{
    partial class TableView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip_node = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createNewFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subfolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rootfolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_table = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.column_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Application = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Url = new System.Windows.Forms.DataGridViewLinkColumn();
            this.column_LastChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip_node.SuspendLayout();
            this.contextMenuStrip_table.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_Id,
            this.column_Application,
            this.column_Username,
            this.column_Password,
            this.column_Category,
            this.column_Url,
            this.column_LastChange});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 403);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(92, 403);
            this.treeView1.TabIndex = 1;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(872, 403);
            this.splitContainer1.SplitterDistance = 92;
            this.splitContainer1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 403);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(92, 0);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 0);
            this.panel1.TabIndex = 1;
            // 
            // contextMenuStrip_node
            // 
            this.contextMenuStrip_node.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewFolderToolStripMenuItem,
            this.createNewEntryToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.openToolStripMenuItem,
            this.moveToolStripMenuItem});
            this.contextMenuStrip_node.Name = "contextMenuStrip1";
            this.contextMenuStrip_node.Size = new System.Drawing.Size(133, 136);
            // 
            // createNewFolderToolStripMenuItem
            // 
            this.createNewFolderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subfolderToolStripMenuItem,
            this.rootfolderToolStripMenuItem});
            this.createNewFolderToolStripMenuItem.Name = "createNewFolderToolStripMenuItem";
            this.createNewFolderToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.createNewFolderToolStripMenuItem.Text = "New folder";
            // 
            // subfolderToolStripMenuItem
            // 
            this.subfolderToolStripMenuItem.Enabled = false;
            this.subfolderToolStripMenuItem.Name = "subfolderToolStripMenuItem";
            this.subfolderToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.subfolderToolStripMenuItem.Text = "Subfolder";
            this.subfolderToolStripMenuItem.Click += new System.EventHandler(this.subfolderToolStripMenuItem_Click);
            // 
            // rootfolderToolStripMenuItem
            // 
            this.rootfolderToolStripMenuItem.Name = "rootfolderToolStripMenuItem";
            this.rootfolderToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.rootfolderToolStripMenuItem.Text = "Rootfolder";
            this.rootfolderToolStripMenuItem.Click += new System.EventHandler(this.rootfolderToolStripMenuItem_Click);
            // 
            // createNewEntryToolStripMenuItem
            // 
            this.createNewEntryToolStripMenuItem.Name = "createNewEntryToolStripMenuItem";
            this.createNewEntryToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.createNewEntryToolStripMenuItem.Text = "New entry";
            this.createNewEntryToolStripMenuItem.Click += new System.EventHandler(this.createNewEntryToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.Enabled = false;
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.moveToolStripMenuItem.Text = "Move";
            this.moveToolStripMenuItem.Click += new System.EventHandler(this.moveToolStripMenuItem_Click);
            // 
            // contextMenuStrip_table
            // 
            this.contextMenuStrip_table.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuStrip_table.Name = "contextMenuStrip_table";
            this.contextMenuStrip_table.Size = new System.Drawing.Size(118, 92);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usernameToolStripMenuItem,
            this.passwordToolStripMenuItem,
            this.urlToolStripMenuItem});
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // usernameToolStripMenuItem
            // 
            this.usernameToolStripMenuItem.Name = "usernameToolStripMenuItem";
            this.usernameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usernameToolStripMenuItem.Text = "Username";
            this.usernameToolStripMenuItem.Click += new System.EventHandler(this.usernameToolStripMenuItem_Click);
            // 
            // passwordToolStripMenuItem
            // 
            this.passwordToolStripMenuItem.Name = "passwordToolStripMenuItem";
            this.passwordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.passwordToolStripMenuItem.Text = "Password";
            this.passwordToolStripMenuItem.Click += new System.EventHandler(this.passwordToolStripMenuItem_Click);
            // 
            // urlToolStripMenuItem
            // 
            this.urlToolStripMenuItem.Name = "urlToolStripMenuItem";
            this.urlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.urlToolStripMenuItem.Text = "Url";
            this.urlToolStripMenuItem.Click += new System.EventHandler(this.urlToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // column_Id
            // 
            this.column_Id.HeaderText = "Guid";
            this.column_Id.Name = "column_Id";
            this.column_Id.ReadOnly = true;
            this.column_Id.Visible = false;
            // 
            // column_Application
            // 
            this.column_Application.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_Application.HeaderText = "Application";
            this.column_Application.Name = "column_Application";
            this.column_Application.ReadOnly = true;
            // 
            // column_Username
            // 
            this.column_Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_Username.HeaderText = "Username";
            this.column_Username.Name = "column_Username";
            this.column_Username.ReadOnly = true;
            // 
            // column_Password
            // 
            this.column_Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_Password.HeaderText = "Password";
            this.column_Password.Name = "column_Password";
            this.column_Password.ReadOnly = true;
            // 
            // column_Category
            // 
            this.column_Category.HeaderText = "Category";
            this.column_Category.Name = "column_Category";
            this.column_Category.ReadOnly = true;
            // 
            // column_Url
            // 
            this.column_Url.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_Url.HeaderText = "Url";
            this.column_Url.Name = "column_Url";
            this.column_Url.ReadOnly = true;
            // 
            // column_LastChange
            // 
            this.column_LastChange.HeaderText = "Last change";
            this.column_LastChange.Name = "column_LastChange";
            this.column_LastChange.ReadOnly = true;
            // 
            // TableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.splitContainer1);
            this.Name = "TableView";
            this.Size = new System.Drawing.Size(872, 403);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip_node.ResumeLayout(false);
            this.contextMenuStrip_table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_node;
        private System.Windows.Forms.ToolStripMenuItem createNewFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_table;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usernameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subfolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rootfolderToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Application;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Category;
        private System.Windows.Forms.DataGridViewLinkColumn column_Url;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_LastChange;
    }
}
