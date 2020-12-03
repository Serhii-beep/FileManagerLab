using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace FileManagerLab
{
    public partial class TextEditorForm : Form
    {
        private string pathToFile = String.Empty;
        private List<string> allWords;
        public TextEditorForm()
        {
            InitializeComponent();
        }

        public TextEditorForm(string _pathToFile)
        {
            this.pathToFile = _pathToFile;
            InitializeComponent();
            Editor editor;
            Creator creator = new EditorCreator();
            editor = creator.Create(Path.GetExtension(pathToFile), null, pathToFile);
            rtbTextEditor.Text = editor.Open();
            allWords = new List<string>();
            using(StreamReader sr = new StreamReader("D:\\Words.txt"))
            {
                while(!sr.EndOfStream)
                {
                    allWords.Add(sr.ReadLine());
                }
            }
        }

        private void menuItemSaveFile_Click(object sender, EventArgs e)
        {

            Editor editor;
            Creator creator = new EditorCreator();
            editor = creator.Create(Path.GetExtension(pathToFile), rtbTextEditor.Text, pathToFile);
            editor.Save();
        }

        private void btnChangeSequence_Click(object sender, EventArgs e)
        {
            if(tbWhatChange.Text == String.Empty)
            {
                MessageBox.Show("Потрібно записати яку послідовність замінити");
            }
            else if(tbToWhatChange.Text == String.Empty)
            {
                MessageBox.Show("Потрібно записати на яку послідовність замінити");
            }
            else
            {
                rtbTextEditor.Text = TextHandler.ChangeWordsSequence(rtbTextEditor.Text, tbWhatChange.Text, tbToWhatChange.Text);
            }

        }

        
        private void TextEditorForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.F7:

                    MessageBox.Show(TextHandler.FindFuzzyWords(allWords, rtbTextEditor.SelectedText), "Найбільш схожі слова");
                    break;
            }
        }

        private void TextEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dr = MessageBox.Show("Ви дійсно хочете вийти? Не забудьте зберегти зміни", "Підтвердження про вихід", MessageBoxButtons.YesNo);
            e.Cancel = (dr == DialogResult.Yes ? false : true);
        }

        private void toolStripMenuItemHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Операції текстового редактора:\n" +
                "Для заміни однієї послідовності символів іншою, потрібно ввести ці послідовності у відповідних полях та натиснути кнопку Замінити\n" +
                "Для знаходження найбільш схожого слова зі списку до виділеного слова, потрібно натиснути F7\n" +
                "Список цих слів міститься в файлі D:\\Words.txt, його можна змінювати");
        }
    }
}
