using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FileManagerLab
{
    public partial class Form1 : Form
    {
        private FileManager fileManager;
        private PrintManager printManager;
        private FileHandler fileHandler;
        public Form1()
        {
            InitializeComponent();
            fileManager = FileManager.GetInstance();
            printManager = new PrintManager(listViewDirectories, listViewFiles);
            fileHandler = new FileHandler(printManager);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listViewFiles.Items.Clear();
            printManager.printDrives(FileManager.getDrives());
        }

        private void listViewDirectories_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItem = listViewDirectories.SelectedItems[0].Text;
            fileHandler.GoNext(selectedItem);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            fileHandler.GoBack();
        }

        private void listViewFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string path = Path.Combine(fileManager.CurrentPath, listViewFiles.SelectedItems[0].Text);
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Extension == ".txt" || fileInfo.Extension == ".dat")
            {
                TextEditorForm textEditor = new TextEditorForm(Path.Combine(path));
                textEditor.Show();
            }
            else
            {
                var proc = new Process();
                proc.StartInfo.FileName = path;
                proc.StartInfo.UseShellExecute = true;
                proc.Start();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.F3:
                    if (listViewFiles.SelectedItems.Count != 0)
                    {
                        listViewFiles_MouseDoubleClick(this, null);                       
                    }
                    break;
                case Keys.F5:
                    if(listViewFiles.SelectedItems.Count != 0)
                    {
                        if ((int)nUDBytes.Value > 0)
                        {
                            fileHandler.DivideFile(Path.Combine(fileManager.CurrentPath, listViewFiles.SelectedItems[0].Text), (int)nUDBytes.Value);
                        }
                        else
                        {
                            MessageBox.Show("Введіть число більше за 0");
                        }
                    }
                    break;
                case Keys.F6:
                    if (listViewFiles.SelectedItems.Count != 0 && Path.GetExtension(listViewFiles.SelectedItems[0].Text) == ".html")
                    {
                        MessageBox.Show(fileHandler.GetUrlsFromHtml(Path.Combine(fileManager.CurrentPath, listViewFiles.SelectedItems[0].Text)), "Список файлів, гіпертекстові посилання на які місяться в цьому html файлі");
                    }
                    break;
            }
            
        }


        private void listViewFiles_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label != null)
            {
                fileHandler.Rename(Path.Combine(fileManager.CurrentPath, oldFileName), e.Label);
            }
        }

        private string oldFileName = String.Empty;
        private void listViewFiles_BeforeLabelEdit(object sender, LabelEditEventArgs e)
        {
            oldFileName = listViewFiles.SelectedItems[0].Text;
        }

        private void menuItemHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Операції файлового менеджреа:\n " +
                "Для поділу файлу на частини, потрібно вибрати файл та натиснути F5," +
                " до цього потрібно задати розмір кожної частини, в полі розміщеному під кнопкою назад\n" +
                "Для формування списку файлів, гіпертекстові посилання на які містяться в заданому html файлі," +
                "потрібно вибрати цей html файл та натиснути F6");
        }
    }
}

