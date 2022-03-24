
namespace KeySafe.UserControls
{
    partial class LoginView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_pw = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox_saveFiles = new System.Windows.Forms.ListBox();
            this.button_AddExisting = new System.Windows.Forms.Button();
            this.button_CreateKeySaveFile = new System.Windows.Forms.Button();
            this.openFileDialog_OpenKeySaveFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_CreateNew = new System.Windows.Forms.SaveFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button_login, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(719, 397);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox_pw
            // 
            this.textBox_pw.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_pw.Location = new System.Drawing.Point(3, 3);
            this.textBox_pw.Name = "textBox_pw";
            this.textBox_pw.PasswordChar = '*';
            this.textBox_pw.Size = new System.Drawing.Size(158, 20);
            this.textBox_pw.TabIndex = 0;
            this.textBox_pw.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_pw_KeyUp);
            // 
            // button_login
            // 
            this.button_login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_login.Enabled = false;
            this.button_login.Location = new System.Drawing.Point(321, 201);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 1;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(233, 391);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.listBox_saveFiles, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_AddExisting, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_CreateKeySaveFile, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(233, 391);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // listBox_saveFiles
            // 
            this.listBox_saveFiles.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.SetColumnSpan(this.listBox_saveFiles, 2);
            this.listBox_saveFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_saveFiles.FormattingEnabled = true;
            this.listBox_saveFiles.HorizontalScrollbar = true;
            this.listBox_saveFiles.Location = new System.Drawing.Point(3, 3);
            this.listBox_saveFiles.Name = "listBox_saveFiles";
            this.listBox_saveFiles.Size = new System.Drawing.Size(227, 356);
            this.listBox_saveFiles.TabIndex = 1;
            this.listBox_saveFiles.SelectedIndexChanged += new System.EventHandler(this.listBox_saveFiles_SelectedIndexChanged);
            // 
            // button_AddExisting
            // 
            this.button_AddExisting.AutoSize = true;
            this.button_AddExisting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_AddExisting.Location = new System.Drawing.Point(3, 365);
            this.button_AddExisting.Name = "button_AddExisting";
            this.button_AddExisting.Size = new System.Drawing.Size(110, 23);
            this.button_AddExisting.TabIndex = 0;
            this.button_AddExisting.Text = "Add existing";
            this.button_AddExisting.UseVisualStyleBackColor = true;
            this.button_AddExisting.Click += new System.EventHandler(this.button_AddExisting_Click);
            // 
            // button_CreateKeySaveFile
            // 
            this.button_CreateKeySaveFile.AutoSize = true;
            this.button_CreateKeySaveFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_CreateKeySaveFile.Location = new System.Drawing.Point(119, 365);
            this.button_CreateKeySaveFile.Name = "button_CreateKeySaveFile";
            this.button_CreateKeySaveFile.Size = new System.Drawing.Size(111, 23);
            this.button_CreateKeySaveFile.TabIndex = 2;
            this.button_CreateKeySaveFile.Text = "Create new";
            this.button_CreateKeySaveFile.UseVisualStyleBackColor = true;
            this.button_CreateKeySaveFile.Click += new System.EventHandler(this.button_CreateNew_Click);
            // 
            // openFileDialog_OpenKeySaveFile
            // 
            this.openFileDialog_OpenKeySaveFile.DefaultExt = "ksf";
            this.openFileDialog_OpenKeySaveFile.Filter = "\"Keysavefiles (*.ksf)|*.ksf";
            this.openFileDialog_OpenKeySaveFile.FilterIndex = 2;
            // 
            // saveFileDialog_CreateNew
            // 
            this.saveFileDialog_CreateNew.CreatePrompt = true;
            this.saveFileDialog_CreateNew.DefaultExt = "ksf";
            this.saveFileDialog_CreateNew.Filter = "\"Keysavefiles (*.ksf)|*.ksf\"";
            this.saveFileDialog_CreateNew.RestoreDirectory = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Location = new System.Drawing.Point(262, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 26);
            this.panel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.textBox_pw, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(193, 26);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KeySafe.Properties.Resources._1557;
            this.pictureBox1.Location = new System.Drawing.Point(167, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LoginView";
            this.Size = new System.Drawing.Size(719, 397);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_pw;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox_saveFiles;
        private System.Windows.Forms.Button button_AddExisting;
        private System.Windows.Forms.OpenFileDialog openFileDialog_OpenKeySaveFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_CreateKeySaveFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_CreateNew;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
