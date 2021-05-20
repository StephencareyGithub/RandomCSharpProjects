using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortFileAlphabetically
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Specify: File Path , New File Name");
            args = Console.ReadLine().Split(',');

            if (args != null)
            {
                MyFile _MyFile = new MyFile(args[0], args[1]);
                var Reading = _MyFile.ReadAndSortFile();

                if (Reading == "File Sorted")
                {
                    _MyFile.SaveFile();
                    Console.WriteLine("File Created" + _MyFile._newfile);
                }
                else
                {
                    Console.WriteLine("Problem finding or reading file");
                    Console.WriteLine("Ensure Your path is correct");
                }
            }
            else
            {
                Console.WriteLine("No arguments specified");
            }

            Console.ReadKey();
        }
    }
}
