using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace PassList_Creator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter File Adress: ");
            string FileAdress = Console.ReadLine();
            StreamReader SR = new StreamReader(FileAdress);
            Console.ReadKey();
        }
    }
}
