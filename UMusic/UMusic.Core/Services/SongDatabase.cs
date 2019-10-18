using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UMusic.Core.Services
{
    public class SongDatabase
    {
        public static ArrayList GetFiles(string[] paths)
        {
            ArrayList files = new ArrayList();

            foreach (string path in paths)
            {
                string[] pathFiles = Directory.GetFiles(path);

                foreach (string pathFile in pathFiles)
                {
                    files.Add(pathFile);
                }
            }

            return files;
        }
    }
}
