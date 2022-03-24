using System;
using System.Collections.Generic;
using System.IO;
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

        private string path = String.Empty;
        private string password = String.Empty;

        public Form1()
        {
            InitializeComponent();
            ShowLoginView();
        }

        private void TableView_OnLogoutRequest()
        {
            ShowLoginView();
        }

        private void ShowTableView()
        {
            if (this.loginView != null)
            {
                this.loginView.OnLoginRequest -= LoginView_OnLoginRequest;
                this.loginView.OnCreatePassword -= LoginView_OnCreatePassword;
                this.Controls.Remove(this.loginView);
                this.loginView.Dispose();
                this.loginView = null;
            }

            this.tableView = new TableView();
            this.tableView.OnKeySafeFileChanged += TableView_OnKeySafeFileChanged;
            this.tableView.OnLogoutRequest += TableView_OnLogoutRequest;
            this.tableView.Init(this.file);
            this.Controls.Add(this.tableView);
        }

        private void ShowLoginView()
        {
            if (tableView != null)
            {
                this.tableView.OnKeySafeFileChanged -= TableView_OnKeySafeFileChanged;
                this.tableView.OnLogoutRequest -= TableView_OnLogoutRequest;
                this.Controls.Remove(this.tableView);
                this.tableView.Dispose();
                this.tableView = null;
                this.password = String.Empty;
                this.path = String.Empty;
                this.file = null;
            }

            this.loginView = new LoginView();
            this.loginView.OnLoginRequest += LoginView_OnLoginRequest;
            this.loginView.OnCreatePassword += LoginView_OnCreatePassword;
            this.loginView.Dock = DockStyle.Fill;
            this.Controls.Add(loginView);
        }

        private void LoginView_OnCreatePassword(string filename)
        {
            CreatePassword createPassword = new CreatePassword();
            DialogResult dialogResult = createPassword.ShowDialog(this);
            if(dialogResult == DialogResult.OK)
            {
                FileHandling.CreateFile(filename, createPassword.Password);
            }
            else
            {
                this.loginView.CancelLogin();
            }
            createPassword.Dispose();
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

        private void LoginView_OnLoginRequest(string filename, string password)
        {
            try
            {
                DialogResult dialogResult = DialogResult.None;
                if (!File.Exists(filename))
                {
                    string text = $"The selected file did not exist. Do you want to create a new file under:\n{filename}";
                    dialogResult = MessageBox.Show(text, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            File.Create(filename).Close();
                            LoginView_OnCreatePassword(filename);
                            return;
                        }
                        catch (Exception)
                        {
                            throw new FileNotFoundException("File could not be created.");
                        }
                    }
                    else throw new FileNotFoundException();
                }

                

                this.path = filename;
                this.password = password;
                this.file = FileHandling.LoadFile(this.path, this.password);

                ShowTableView();
                
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
                MessageBox.Show(ex.Message);
            }
        }
    }
}
