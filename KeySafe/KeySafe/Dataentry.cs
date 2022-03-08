using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeySafe
{
    public class Dataentry
    {
        //TODO implement parentfolder
        public Folder ParentFolder { get; set; }
        public string Guid { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Application { get; set; }
        public string Category { get; set; }
        public string LastChanged { get; set; }
        public string Url { get; set; }
    }
    public class Category
    {
        public string Name { get; set; }
        public List<Dataentry> DataEntries { get; set; }
    }
    public class Folder
    {
        public string Guid { get; set; }
        public string Name { get; set; }

        //TODO: Add list of Folder for subfolder
        //public List<Folder> Subfolder { get; set; }

        public List<Dataentry> DataEntries { get; set; }
    }

    public class KeySafeFile
    {
        public List<Category> Categories { get; set; }
        public List<Folder> Folder { get; set; }
    }
}
