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

            Console.ReadKey();
        }

    }
}
