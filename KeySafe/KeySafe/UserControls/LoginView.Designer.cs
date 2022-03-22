﻿
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
            this.listBox_saveFiles = new System.Windows.Forms.ListBox();
            this.button_AddKeySaveFile = new System.Windows.Forms.Button();
            this.openFileDialog_OpenKeySaveFile = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_pw, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_login, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
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
            this.textBox_pw.Location = new System.Drawing.Point(308, 175);
            this.textBox_pw.Name = "textBox_pw";
            this.textBox_pw.PasswordChar = '*';
            this.textBox_pw.Size = new System.Drawing.Size(100, 20);
            this.textBox_pw.TabIndex = 0;
            this.textBox_pw.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_pw_KeyUp);
            // 
            // button_login
            // 
            this.button_login.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.panel1.Controls.Add(this.listBox_saveFiles);
            this.panel1.Controls.Add(this.button_AddKeySaveFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(233, 391);
            this.panel1.TabIndex = 2;
            // 
            // listBox_saveFiles
            // 
            this.listBox_saveFiles.BackColor = System.Drawing.SystemColors.Control;
            this.listBox_saveFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_saveFiles.FormattingEnabled = true;
            this.listBox_saveFiles.Location = new System.Drawing.Point(0, 0);
            this.listBox_saveFiles.Name = "listBox_saveFiles";
            this.listBox_saveFiles.Size = new System.Drawing.Size(233, 368);
            this.listBox_saveFiles.TabIndex = 1;
            // 
            // button_AddKeySaveFile
            // 
            this.button_AddKeySaveFile.AutoSize = true;
            this.button_AddKeySaveFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_AddKeySaveFile.Location = new System.Drawing.Point(0, 368);
            this.button_AddKeySaveFile.Name = "button_AddKeySaveFile";
            this.button_AddKeySaveFile.Size = new System.Drawing.Size(233, 23);
            this.button_AddKeySaveFile.TabIndex = 0;
            this.button_AddKeySaveFile.Text = "Add .ksf file";
            this.button_AddKeySaveFile.UseVisualStyleBackColor = true;
            this.button_AddKeySaveFile.Click += new System.EventHandler(this.button_AddKeySaveFile_Click);
            // 
            // openFileDialog_OpenKeySaveFile
            // 
            this.openFileDialog_OpenKeySaveFile.DefaultExt = "ksf";
            this.openFileDialog_OpenKeySaveFile.FileName = "openFileDialog1";
            this.openFileDialog_OpenKeySaveFile.Filter = "\"Keysavefiles (*.ksf)|*.ksf\"";
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
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_pw;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox_saveFiles;
        private System.Windows.Forms.Button button_AddKeySaveFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog_OpenKeySaveFile;
    }
}
