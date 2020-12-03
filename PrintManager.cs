using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace FileManagerLab
{
    public class PrintManager
    {
        private ListView listViewFolders;
        private ListView listViewFiles;
        public PrintManager(ListView folders, ListView files)
        {
            listViewFolders = folders;
            listViewFiles = files;
        }
        public void printFolders(DirectoryInfo[] directories)
        {
            listViewFolders.Items.Clear();
            foreach (var directory in directories)
            {
                listViewFolders.Items.Add(ConfigureListViewItem(0, directory.Name));
            }
        }
        public void printDrives(DriveInfo[] drives)
        {
            listViewFolders.Items.Clear();
            foreach (var drive in drives)
            {
                listViewFolders.Items.Add(ConfigureListViewItem(0, drive.Name));
            }
        }
        public void printFiles(FileInfo[] files)
        {
            listViewFiles.Items.Clear();
            foreach (var file in files)
            {
                listViewFiles.Items.Add(ConfigureListViewItem(1, file.Name));
            }
        }
        private ListViewItem ConfigureListViewItem(int imageIndex, string text)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = text;
            lvi.ImageIndex = imageIndex;
            return lvi;
        }

        public void Update(DirectoryInfo[] directories, FileInfo[] files)
        {
            if(directories != null && files != null)
            {
                printFolders(directories);
                printFiles(files);
            }
            else
            {
                printDrives(FileManager.getDrives());
                listViewFiles.Items.Clear();
            }
        }
    }
}
