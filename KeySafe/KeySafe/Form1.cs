using System;
using System.Collections.Generic;
using System.Windows.Forms;
using KeySafe.UserControls;

///TODO: If the password should be changed the user need to enter the old password and the new password. 
///The file will be decrypted with the old password and encrypted with the new password. Just open the file and close the file. It dont need to be changed anything else.


/// <summary>
/// 
/// </summary>
namespace KeySafe
{
    public partial class Form1 : Form
    {
        KeySafeFile file;

        LoginView loginView = null;
        TableView tableView = null;

        private string path = "save.ksf";
        private string password = String.Empty;

        public Form1()
        {
            //PrefillFile();
            //TODO let user select files or create new files
            InitializeComponent();
            this.loginView = new LoginView();
            this.loginView.OnLoginRequest += LoginView_OnLoginRequest;
            this.loginView.Dock = DockStyle.Fill;
            this.Controls.Add(loginView);

            this.tableView = new TableView();
            this.tableView.OnKeySafeFileChanged += TableView_OnKeySafeFileChanged;
        }

        private void TableView_OnKeySafeFileChanged()
        {
            FileHandling.SaveFile(this.file, this.path, this.password);
        }

        private void PrefillFile()
        {
            this.file = FileHandling.LoadFile(this.path, "Hallo");
            for (int folderIndex = 0; folderIndex < 4; folderIndex++)
            {
                Folder folder = new Folder();
                folder.Name = $"My {folderIndex} folder";
                folder.DataEntries = new List<Dataentry>();
                for (int dataEntryIndex = 0; dataEntryIndex < 4; dataEntryIndex++)
                {
                    Dataentry entry = new Dataentry();
                    entry.Guid = Guid.NewGuid().ToString();
                    entry.Application = $"My {folderIndex}/{dataEntryIndex} Application";
                    entry.Category = $"My {folderIndex}/{dataEntryIndex} Category";
                    entry.UserName = $"My {folderIndex}/{dataEntryIndex} Username";
                    entry.Password = $"My {folderIndex}/{dataEntryIndex} Password";
                    entry.Url = $"My {folderIndex}/{dataEntryIndex} Url";
                    entry.LastChanged = $"My {folderIndex}/{dataEntryIndex} Date";
                    folder.DataEntries.Add(entry);
                }
                if (this.file.Folder == null) this.file.Folder = new List<Folder>();
                this.file.Folder.Add(folder);
            }
            FileHandling.SaveFile(this.file, this.path, "Hallo");
            this.file = null;
        }

        private void LoginView_OnLoginRequest(string password)
        {
            try
            {
                //TODO if file did not exist ask about filename and password encrypt
                this.password = password;
                this.file = FileHandling.LoadFile(this.path, this.password);
                Console.WriteLine("Access granted!");

                this.Controls.Remove(this.loginView);
                this.loginView.Dispose();

                this.tableView.Init(this.file);
                this.Controls.Add(this.tableView);
            }
            catch (System.Security.Cryptography.CryptographicException)
            {
                string message = $"Wrong password!";
                DialogResult dr = MessageBox.Show(this, message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if(dr != DialogResult.Retry)
                {
                    this.Dispose();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Access not granted!");
                Console.WriteLine(ex);
            }
        }
    }
}
