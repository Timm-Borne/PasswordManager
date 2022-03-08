using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeySafe
{
    public partial class Form_DataEntry : Form
    {
        public enum Categories
        {
            NONE, WORK, PRIVATE, GAMES, RANDOM, BUSINESS
        }

        private Dataentry _entry = null;
        public Dataentry Entry
        {
            get { return this._entry; }
            private set
            {
                this._entry = value;
                this.textBox_application.Text = value.Application;
                this.textBox_userName.Text = value.UserName;
                this.textBox_password.Text = value.Password;
                this.textBox_url.Text = value.Url;

                if (this.comboBox_category.Items.Contains(value.Category)) this.comboBox_category.SelectedItem = value.Category;
                else this.comboBox_category.SelectedIndex = 0;
            }
        }

        public string ParentFolder
        {
            get { return this.comboBox_folder.SelectedItem.ToString(); }
            set
            {
                foreach (string item in this.comboBox_folder.Items)
                {
                    if (item.Equals(value))
                    {
                        this.comboBox_folder.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        public Form_DataEntry(List<Folder> parentFolderList)
        {
            InitializeComponent();
            _entry = new Dataentry();
            foreach (Categories category in Enum.GetValues(typeof(Categories)))
            {
                this.comboBox_category.Items.Add(category);
            }
            this.comboBox_category.SelectedIndex = 0;

            foreach (Folder folder in parentFolderList)
            {
                this.comboBox_folder.Items.Add(folder.Name);
            }
            this.comboBox_folder.SelectedIndex = 0;
        }

        public Form_DataEntry(List<Folder> parentFolderList, Dataentry entry)
        {
            InitializeComponent();

            foreach (Categories category in Enum.GetValues(typeof(Categories)))
            {
                this.comboBox_category.Items.Add(category);
            }
            this.comboBox_category.SelectedIndex = 0;

            foreach (Folder folder in parentFolderList)
            {
                this.comboBox_folder.Items.Add(folder.Name);
            }
            this.comboBox_folder.SelectedIndex = 0;

            this.Entry = entry;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_okay_Click(object sender, EventArgs e)
        {
            _entry.Application = this.textBox_application.Text;
            _entry.UserName = this.textBox_userName.Text;
            _entry.Category = this.comboBox_category.SelectedItem.ToString();
            _entry.Url = this.textBox_url.Text;
            _entry.Password = this.textBox_password.Text;
            _entry.LastChanged = DateTime.Today.ToString("D");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
