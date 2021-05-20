using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortFileAlphabetically
{
    class MyFile
    {
        private string _path { get; set; }
        private string _name { get; set; }
        public string _rootPath { get; set; }
        public string _newfile { get; set; }

        private List<string> Lines;

        public MyFile(string Path, string Name)
        {
            _path = Path;
            _name = Name;

            int index = Path.LastIndexOf(@"\");
            if (index > 0)
                _rootPath = Path.Substring(0, index);

            _newfile = _rootPath + "\\" +  _name + ".txt";
        }

        public string ReadAndSortFile()
        {
            try
            {
                int counter = 0;
                string line;
                Lines = new List<string>();
                System.IO.StreamReader file = new System.IO.StreamReader(_path);
                while ((line = file.ReadLine()) != null)
                {
                    if (line != string.Empty) Lines.Add(line);
                    counter++;
                }

                Lines.Sort();

                return "File Sorted";
            }
            catch (Exception ex)
            {
                return "Error:  " + ex.ToString();
            }
        }


        public string SaveFile()
        {
            try
            {
                if (!File.Exists(_newfile))
                {
                    using (StreamWriter sw = File.CreateText(_newfile))
                    {
                        foreach (string line in Lines)
                            sw.WriteLine(line);

                    }

                    
                    return "File created: " + _newfile;
                }
                return "Error: File already exists";
            }
            catch(Exception ex)
            {
                return "Error creating file" + ex.ToString();
            }
        }



    }
}