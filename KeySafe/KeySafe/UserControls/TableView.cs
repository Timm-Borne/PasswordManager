using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SymetricEncryption;

namespace KeySafe.UserControls
{
    public partial class TableView : UserControl
    {
        /// <summary>
        /// The Object in which the data will be stored.
        /// </summary>
        private KeySafeFile file = null;

        /// <summary>
        /// Temporary cell that is selected from the user.
        /// </summary>
        private DataGridViewCell selectedCell = null;

        /// <summary>
        /// Temporary row that is selected from the user.
        /// </summary>
        private DataGridViewRow selectedRow = null;

        /// <summary>
        /// Temporary password to encrypt the password in the table view so that the password is not visible in cleartext.
        /// </summary>
        private string tempPassword = "mf&/%ui958/(6087kmfE*#SDFaXREA";

        /// <summary>
        /// Creates a new Usercontrol to view the table and file tree.
        /// </summary>
        public TableView()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Initializate the control and set the object in which the data is stored. Without the initialization the table can not be filled.
        /// </summary>
        /// <param name="file"></param>
        public void Init(KeySafeFile file)
        {
            this.file = file;
            FillTreeView();
        }

        /// <summary>
        /// This event is triggered everytime the file has been changed so that the changes will be sved encrypted in file.
        /// </summary>
        public delegate void OnKeySafeFileChangedDeligate();
        public event OnKeySafeFileChangedDeligate OnKeySafeFileChanged;

        /// <summary>
        /// Get the folder object with the specific name.
        /// </summary>
        /// <param name="name">The name of the folder.</param>
        /// <returns>The folder object with the specific name.</returns>
        private Folder GetFolderByName(string name)
        {
            //TODO check if subfolder
            foreach (Folder folder in this.file.Folder)
            {
                if (folder.Name.Equals(name)) return folder;
            }
            return null;
        }
        
        #region Table actions

        /// <summary>
        /// Fill the table with the entries of the selected folder.
        /// </summary>
        public void FillTable()
        {
            //Iterate through every dataentry in the selected folder
            foreach (Dataentry dataentry in GetFolderByName(this.treeView_folderExplorer.SelectedNode.Text).DataEntries)
            {
                //create for every entry a new row and add it to the table
                DataGridViewRow row = new DataGridViewRow();

                object[] entries = { dataentry.Guid, dataentry.Application, dataentry.UserName, Encrypt.Text(dataentry.Password,this.tempPassword), dataentry.Category, dataentry.Url, dataentry.LastChanged};
                
                row.CreateCells(this.dataGridView_dataTable, entries);

                this.dataGridView_dataTable.Rows.Add(row);
            }
        }

        /// <summary>
        /// Cear the table and fill it again(Refresh).
        /// </summary>
        private void RefreshTable()
        {
            this.dataGridView_dataTable.Rows.Clear();
            FillTable();
        }

        /// <summary>
        /// If the table were clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //If the left mousebutton will be pressed
            if (e.Button == MouseButtons.Right)
            {
                //if the table is empty the user only can add an entry
                if (this.dataGridView_dataTable.Rows.Count <= 0)
                {
                    //disable all functions of the contextmenu except add-function
                    foreach (ToolStripItem item in this.contextMenuStrip_table.Items)
                    {
                        item.Enabled = false;
                    }
                    this.contextMenuStrip_table.Items[0].Enabled = true;
                    this.contextMenuStrip_table.Show(this, e.Location);
                }
            }
        }

        /// <summary>
        /// If the add function of the context menu were clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEntry();
        }

        /// <summary>
        /// If the edit function of the context menu were clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dataentry entry = new Dataentry();
            entry.Guid = this.selectedRow.Cells[this.dataGridView_dataTable.Columns[column_Id.Name].Index].Value.ToString();
            entry.Application = this.selectedRow.Cells[this.dataGridView_dataTable.Columns[column_Application.Name].Index].Value.ToString();
            entry.UserName = this.selectedRow.Cells[this.dataGridView_dataTable.Columns[column_Username.Name].Index].Value.ToString();
            entry.Password = Decrypt.Text(this.selectedRow.Cells[this.dataGridView_dataTable.Columns[column_Password.Name].Index].Value.ToString(), this.tempPassword);
            entry.Category = this.selectedRow.Cells[this.dataGridView_dataTable.Columns[column_Category.Name].Index].Value.ToString();
            entry.Url = this.selectedRow.Cells[this.dataGridView_dataTable.Columns[column_Url.Name].Index].Value.ToString();

            EditEntry(entry);
        }

        /// <summary>
        /// If the copy username function of the context menu were clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void usernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(selectedRow.Cells[column_Username.Name].Value.ToString());
        }

        /// <summary>
        /// If the copy password function of the context menu were clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Decrypt.Text(selectedRow.Cells[column_Password.Name].Value.ToString(), this.tempPassword));
        }

        /// <summary>
        /// If the copy url function of the context menu were clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void urlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(selectedRow.Cells[column_Url.Name].Value.ToString());
        }

        /// <summary>
        /// If the remove function of the context menu were clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Folder selectedFolder = GetFolderByName(this.treeView_folderExplorer.SelectedNode.Text);
            Dataentry selectedEntry = GetDataentryFromGuid(this.selectedRow.Cells[this.dataGridView_dataTable.Columns[column_Id.Name.ToString()].Index].Value.ToString());
            selectedFolder.DataEntries.Remove(selectedEntry);
            RefreshTable();
            OnKeySafeFileChanged();
        }

        /// <summary>
        /// If on cell is selected from the user. Mouse down.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //If the cell is selected with left mousebutton and its the password column
            //the password will be shown in cleartext
            if (e.Button == MouseButtons.Left)
            {
                if (this.selectedCell == null)
                {
                    if (e.ColumnIndex == this.dataGridView_dataTable.Columns[column_Password.Name.ToString()].Index)
                    {
                        this.selectedCell = this.dataGridView_dataTable[e.ColumnIndex, e.RowIndex];
                        this.selectedCell.Value = Decrypt.Text(this.selectedCell.Value.ToString(), this.tempPassword);
                    }
                }
            }
            //If the cell is selected with the right mousebutton and its not the header row
            else if (e.Button == MouseButtons.Right)
            {
                if (this.dataGridView_dataTable.Rows.Count > 0 && e.RowIndex >= 0)
                {
                    foreach (ToolStripItem item in this.contextMenuStrip_table.Items)
                    {
                        item.Enabled = true;
                    }
                    //store the selected row and show the context menu
                    this.selectedRow = new DataGridViewRow();
                    this.selectedRow.CreateCells(this.dataGridView_dataTable);
                    this.selectedRow = this.dataGridView_dataTable.Rows[e.RowIndex];
                    this.contextMenuStrip_table.Show(this, e.Location);
                }
            }
        }
        /// <summary>
        /// If on cell is selected from the user. Mouse up.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(this.selectedCell != null)
            {
                //if the released button is the left mousebutton the password will be shown encrypted
                if (e.Button == MouseButtons.Left)
                {
                    this.selectedCell.Value = Encrypt.Text(this.selectedCell.Value.ToString(), this.tempPassword);
                    this.selectedCell = null;
                }
            }
        }
        #endregion

        #region Tree view actions
        /// <summary>
        /// Fill the treeview with all existing folders.
        /// </summary>
        public void FillTreeView()
        {
            foreach (Folder folder in this.file.Folder)
            {
                this.treeView_folderExplorer.Nodes.Add(folder.Name);
            }
        }

        /// <summary>
        /// Clear the treeview and refill it to refresh the view.
        /// Reselect the previous selected folder.
        /// </summary>
        private void RefreshTreeView()
        {
            TreeNode tempNode = this.treeView_folderExplorer.SelectedNode;
            this.treeView_folderExplorer.Nodes.Clear();
            FillTreeView();
            this.treeView_folderExplorer.SelectedNode = tempNode;
        }
        #endregion

        #region Node actions
        /// <summary>
        /// If the user click at the tree view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Select the node that is clicked
            this.treeView_folderExplorer.SelectedNode = e.Node;

            //if the button is right mousebutton show the context menu
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip_node.Show(this.treeView_folderExplorer, e.Location);
            }
            else
            {
                RefreshTable();
            }
        }

        /// <summary>
        /// If the open item in contextmenu is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        /// <summary>
        /// If the add item in contextmenu is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createNewEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEntry();
        }

        /// <summary>
        /// If the rename item in contextmenu is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderForm renameFolderForm = new FolderForm();

            renameFolderForm.FolderName = this.treeView_folderExplorer.SelectedNode.Text;

            DialogResult dr = renameFolderForm.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                GetFolderByName(this.treeView_folderExplorer.SelectedNode.Text).Name = renameFolderForm.FolderName;

                OnKeySafeFileChanged();
                RefreshTreeView();
            }
            renameFolderForm.Dispose();
        }

        /// <summary>
        /// If the remove item in contextmenu is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = $"Do you realy want to delete folder: {this.treeView_folderExplorer.SelectedNode.Text}?\nAll data in this folder will be deleted and can not be get back!";
            DialogResult dr = MessageBox.Show(this,message,"Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk);
            if (dr == DialogResult.Yes)
            {
                this.file.Folder.Remove(GetFolderByName(this.treeView_folderExplorer.SelectedNode.Text));
                RefreshTreeView();
            }
        }

        /// <summary>
        /// If the move item in contextmenu is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// If the create subfolder item in contextmenu is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subfolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO dont duplicate foldernames
            throw new NotImplementedException();
        }

        /// <summary>
        /// If the create root folder item in contextmenu is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rootfolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderForm addFolderForm = new FolderForm();
            DialogResult dr = addFolderForm.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                if (!FolderExists(addFolderForm.FolderName))
                {
                    Folder folder = new Folder();
                    folder.Name = addFolderForm.FolderName;
                    folder.Guid = Guid.NewGuid().ToString();
                    folder.DataEntries = new List<Dataentry>();

                    this.file.Folder.Add(folder);
                    OnKeySafeFileChanged();
                    RefreshTreeView();
                }
                else
                {
                    string message = $"The name {addFolderForm.FolderName} already exists!";
                    MessageBox.Show(message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            addFolderForm.Dispose();
        }

        /// <summary>
        /// Checks if the given folder currently exist.
        /// </summary>
        /// <param name="folderName"></param>
        /// <returns></returns>
        private bool FolderExists(string folderName)
        {
            foreach (Folder folder in this.file.Folder)
            {
                if (folder.Name.Equals(folderName)) return true;
            }

            return false;
        }
        #endregion

        /// <summary>
        /// Open a frame to enter data for new dataentry.
        /// </summary>
        private void AddEntry()
        {
            Form_DataEntry createDataEntry = new Form_DataEntry(this.file.Folder);
            createDataEntry.ParentFolder = this.treeView_folderExplorer.SelectedNode.Text;
            DialogResult dr = createDataEntry.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                Folder parentFolder = GetFolderByName(createDataEntry.ParentFolder);
                Dataentry entry = createDataEntry.Entry;
                parentFolder.DataEntries.Add(entry);
                OnKeySafeFileChanged();
                //if the folder name is same as selected and showen folder the tabel will refresh
                if (parentFolder.Name.Equals(this.treeView_folderExplorer.SelectedNode.Text))
                {
                    RefreshTable();
                }
            }
            createDataEntry.Dispose();
        }

        /// <summary>
        /// Open a frame to edit an existing entry.
        /// </summary>
        /// <param name="entry">Entry to edit.</param>
        private void EditEntry(Dataentry entry)
        {
            Form_DataEntry createDataEntryForm = new Form_DataEntry(this.file.Folder, entry);

            createDataEntryForm.ParentFolder = this.treeView_folderExplorer.SelectedNode.Text;

            DialogResult dr = createDataEntryForm.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                Folder newParentFolder = GetFolderByName(createDataEntryForm.ParentFolder);
                Dataentry changedDataentry = GetDataentryFromGuid(createDataEntryForm.Entry.Guid);

                changedDataentry.Application = createDataEntryForm.Entry.Application;
                changedDataentry.UserName = createDataEntryForm.Entry.UserName;
                changedDataentry.Password = createDataEntryForm.Entry.Password;
                changedDataentry.Category = createDataEntryForm.Entry.Category;
                changedDataentry.Url = createDataEntryForm.Entry.Url;
                changedDataentry.LastChanged = createDataEntryForm.Entry.LastChanged;

                //If the parentfolder did not changed just the properties will be changed
                if (!createDataEntryForm.ParentFolder.Equals(this.treeView_folderExplorer.SelectedNode.Text))
                {
                    GetFolderByName(this.treeView_folderExplorer.SelectedNode.Text).DataEntries.Remove(GetDataentryFromGuid(createDataEntryForm.Entry.Guid));
                    newParentFolder.DataEntries.Add(createDataEntryForm.Entry);
                }
                OnKeySafeFileChanged();
                RefreshTable();
            }
            createDataEntryForm.Dispose();
        }

        private Dataentry GetDataentryFromGuid(string guid)
        {
            foreach (Folder folder in this.file.Folder)
            {
                foreach (Dataentry dataentry in folder.DataEntries)
                {
                    if (dataentry.Guid.Equals(guid)) return dataentry;
                }
            }
            return null;
        }

        public delegate void OnLogoutRequestDeligate();
        public event OnLogoutRequestDeligate OnLogoutRequest;
        private void button_logout_Click(object sender, EventArgs e)
        {
            OnLogoutRequest();
        }
    }
}
