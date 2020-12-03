using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileManagerLab
{
    class FileHandler
    {
        private PrintManager printManager;
        private FileManager fileManager;
        public FileHandler(PrintManager _printManager)
        {
            printManager = _printManager;
            fileManager = FileManager.GetInstance();
        }
        public void Rename(string path, string newName)
        {
            File.Move(path, Path.Combine(Directory.GetParent(path).FullName, newName));
            printManager.Update(fileManager.getDirectories(), fileManager.getFiles());
        }

        public void DivideFile(string path, int partSize)
        {
            byte[] file = File.ReadAllBytes(path);
            int part = 1;
            int position = 0;
            for (int i = 0; i < file.Length; i += partSize)
            {
                byte[] partbytes = new byte[Math.Min(partSize, file.Length - i)];
                for (int j = 0; j < partbytes.Length; j++)
                {
                    partbytes[j] = file[position++];
                }
                File.WriteAllBytes(Path.Combine(fileManager.CurrentPath, (part++) + Path.GetFileName(path)), partbytes);
            }
            printManager.Update(fileManager.getDirectories(), fileManager.getFiles());
        }
        private List<string> GetHref(string html)
        {
            string[] d = html.Split('\n');
            List<string> HREFS = new List<string>();
            string buf = "";
            foreach (string str in d)
            {
                for (int I = 0; I < str.Length - 4; I++)
                {
                    if (str.Substring(I, 4) == "href")
                    {
                        buf = "";
                        I += 6;
                        while (str.Substring(I, 1) != @"""")

                        {
                            buf += str.Substring(I, 1);
                            I++;
                        }
                    }
                    HREFS.Add(buf);
                }
            }
            return HREFS;
        }
        public string GetUrlsFromHtml(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                StringBuilder sb = new StringBuilder();
                foreach (var url in GetHref(sr.ReadToEnd()))
                {
                    if (!sb.ToString().Contains(url) && Directory.Exists(url))
                    {
                        sb.Append(url);
                        sb.AppendLine();
                    }
                }
                return sb.ToString();
            }
        }
        public void GoNext(string name)
        {
            fileManager.Update(name);
            printManager.Update(fileManager.getDirectories(), fileManager.getFiles());
        }
        public void GoBack()
        {
            if (fileManager.CurrentPath == "D:\\" || fileManager.CurrentPath == "C:\\")
            {
                printManager.Update(null, null);
            }
            else
            {
                fileManager.Update(null);
                printManager.Update(fileManager.getDirectories(), fileManager.getFiles());
            }
        }
    }
}
