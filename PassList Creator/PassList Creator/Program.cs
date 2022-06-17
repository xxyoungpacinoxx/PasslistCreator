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
            Console.WriteLine("Welcome To This Project ...");
            do
            {
                Console.Write
                ("Menue --> R. ReadFile \tW. WriteLine \tE. Exit \nSelect -->");
                char Menu = Convert.ToChar(Console.ReadLine());
                switch (Menu)
                {
                    case 'R':
                        Console.WriteLine("\n\nReadFile Service Is Running ...");
                        Console.Write("Inser File Adress: ");
                        StreamR SR = new StreamR(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine(SR.ReadFile());
                        Console.WriteLine("\nReadFile Service Is Finish!\n");

                        break;

                    case 'W':
                        Console.WriteLine("\n\nWriteFile Service Is Running ...");
                        Console.Write("Inser File Adress: ");
                        string FileAdress = Console.ReadLine();
                        Console.Write("Inser FileName & Fromat (ex: pass.txt): ");
                        string FileName = Console.ReadLine();
                        StreamW SW = new StreamW(FileAdress,FileName);
                        Console.WriteLine();
                        Console.WriteLine("Write: ");
                        SW.FileData = Console.ReadLine();
                        SW.WriteFile();
                        break;

                    case 'E':
                        Console.Write("Are You Sure (Y/N): ");
                        char exitkey = Convert.ToChar(Console.ReadLine());
                        if (exitkey == 'Y')
                        {
                            Environment.Exit(0);
                        }
                        break;

                    default:
                        Console.Write("\nInput False!\n");
                        break;
                }
            } while (true);


            Console.ReadKey();
        }

    }
}
