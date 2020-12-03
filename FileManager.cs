using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileManagerLab
{
    public class FileManager
    {
        private static FileManager _instance;
        private string currentPath = String.Empty;
        private DirectoryInfo currentDirectory;
        public string CurrentPath { get { return currentPath; } }
        private FileManager() { }
        public static FileManager GetInstance()
        {
            if(_instance == null)
            {
                _instance = new FileManager();
            }
            return _instance;
        }
        public static DriveInfo[] getDrives()
        {
            return DriveInfo.GetDrives();
        }
        public DirectoryInfo[] getDirectories()
        {
            currentDirectory = new DirectoryInfo(currentPath);
            return currentDirectory.GetDirectories();
        }
        public FileInfo[] getFiles()
        {
            return currentDirectory.GetFiles();
        }
        public void Update(string name)
        {
            if (name != null)
            {
                currentPath = Path.Combine(currentPath, name);
            }
            else
            {
                currentPath = Directory.GetParent(currentPath).FullName;
            }
        }
    }
}
