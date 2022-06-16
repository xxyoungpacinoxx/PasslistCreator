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
            Console.Write("Enter File Name & Format (pass.txt): ");
            string FileName = Console.ReadLine();

            StreamReader SR = new StreamReader($@"{FileAdress}\{FileName}");
            //StreamWriter SW = new StreamWriter($@"{FileAdress}\{FileName}");

            Console.WriteLine($@"{FileAdress}\{FileName}");
            Console.ReadKey();
        }
    }
}
