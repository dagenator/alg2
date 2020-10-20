using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace Algorithm_s_stek
{
    class File_managment
    {
        public Dictionary<string,string> Commands = new Dictionary<string, string>();
        public File_managment(string path)
        {
            if (!Directory.Exists(path))
            {
                Console.WriteLine("{0} is not a valid file or directory.", path);
            }

            foreach (var e in Directory.GetFiles(path))
            {
                Commands.Add(Path.GetFileNameWithoutExtension(e),  File.ReadAllText(e));
            }
        }
    }
}
