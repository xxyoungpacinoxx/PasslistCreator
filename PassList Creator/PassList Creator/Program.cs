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
<<<<<<< HEAD
            Console.Write("Enter File Adress: ");
            string FileAdress = Console.ReadLine();
            Console.Write("Enter FileName & Format: ");
            string FileName = Console.ReadLine();

            StreamW SW = new StreamW(FileAdress,FileName);
            Console.WriteLine("Write Text: ");
            SW.FileData = Console.ReadLine().ToString();
            SW.WriteFile();
=======
            
            Console.WriteLine("Welcome To This Project ...");
            do
            {
                Console.Write
                ("R. ReadFile \tW. WriteLine \nSelect --> ");
                char Menu = Convert.ToChar(Console.ReadLine());
                switch (Menu)
                {
                    case 'R':


                        break;

                    case 'W':

                        break;

                    default:
                        Console.Write("\nInput False!\n");
                        break;
                }
            } while (true);

>>>>>>> SwitchSystem
            Console.ReadKey();
        }

    }
}
