
namespace KeySafe
{
    partial class FolderForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_folderName = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_okay = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_folderName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_cancel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_okay, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(242, 109);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox_folderName
            // 
            this.textBox_folderName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_folderName, 2);
            this.textBox_folderName.Location = new System.Drawing.Point(44, 31);
            this.textBox_folderName.Name = "textBox_folderName";
            this.textBox_folderName.Size = new System.Drawing.Size(153, 20);
            this.textBox_folderName.TabIndex = 0;
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.Location = new System.Drawing.Point(43, 57);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_okay
            // 
            this.button_okay.Location = new System.Drawing.Point(124, 57);
            this.button_okay.Name = "button_okay";
            this.button_okay.Size = new System.Drawing.Size(75, 23);
            this.button_okay.TabIndex = 2;
            this.button_okay.Text = "Okay";
            this.button_okay.UseVisualStyleBackColor = true;
            this.button_okay.Click += new System.EventHandler(this.button_okay_Click);
            // 
            // AddFolderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(242, 109);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddFolderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddFolderForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_folderName;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_okay;
    }
}