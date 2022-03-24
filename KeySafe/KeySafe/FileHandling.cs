using System;
using System.Collections.Generic;
using System.IO;
using SymetricEncryption;
using System.Text.Json;
using System.Windows.Forms;

namespace KeySafe
{
    class FileHandling
    {
        public static KeySafeFile LoadFile(string path, string password)
        {
            try
            {
                if (!File.Exists(path))
                {
                    CreateFile(path, password);
                }
                
                string text = File.ReadAllText(path);

                text = Decrypt.Text(text, password);

                KeySafeFile keySafeFile = null;
                try
                {
                    keySafeFile = JsonSerializer.Deserialize<KeySafeFile>(text);
                }
                catch (JsonException)
                {
                    CreateFile(path, password);
                    return LoadFile(path, password);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                return keySafeFile;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static bool SaveFile(KeySafeFile keySafeFileObject, string path, string password)
        {
            try
            {
                string text = JsonSerializer.Serialize<KeySafeFile>(keySafeFileObject);

                text = Encrypt.Text(text, password);

                File.WriteAllText(path, text);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void CreateFile(string path, string password)
        {
            KeySafeFile ksf = new KeySafeFile();
            ksf.Folder = new List<Folder>();
            
            Folder folder = new Folder();
            folder.Name = "Default";

            folder.DataEntries = new List<Dataentry>();

            ksf.Folder.Add(folder);
            SaveFile(ksf, path, password);
        }
    }
}
