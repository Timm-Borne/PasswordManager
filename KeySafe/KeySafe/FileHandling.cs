using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SymetricEncryption;
using System.Text.Json;

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
                    Console.WriteLine("New File will be created!");
                    CreateFile(path, password);
                }
                
                string text = File.ReadAllText(path);

                text = Decrypt.Text(text, password);

                return JsonSerializer.Deserialize<KeySafeFile>(text);
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

        private static void CreateFile(string path, string password)
        {
            KeySafeFile ksf = new KeySafeFile();
            ksf.Folder = new List<Folder>();
            
            Folder folder = new Folder();
            folder.Name = "Dafault";

            folder.DataEntries = new List<Dataentry>();

            ksf.Folder.Add(folder);
            SaveFile(ksf, path, password);
        }
    }
}
