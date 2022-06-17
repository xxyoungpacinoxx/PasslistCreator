using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace PassList_Creator
{
    internal class StreamR
    {
        public StreamR(string v)
        {
            FileAdress = v;
        }
        public string FileAdress { get; set; }
        public string FileData { get; set; }

        public string ReadFile() 
        {
            StreamReader sr = new StreamReader(FileAdress);
            return FileData = sr.ReadToEnd();
        }
        
    }
}
