using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PassList_Creator
{
    internal class StreamW
    {
        public StreamW(string fileAdress, string fileName) 
        {
            FileAdress = fileAdress;
            FileName = fileName;
        }
        
        public string FileAdress { get; set; }
        public string FileName { get; set; }
        public string FileData { get; set; }

        public string BuildAdress() 
        {
            return ($@"{FileAdress}\{FileName}");
        }
        public bool WriteFile() 
        {
            StreamWriter SW = new StreamWriter(BuildAdress());
            SW.WriteLine(FileData);
            SW.Close();
            return true;
        }
    }
}
