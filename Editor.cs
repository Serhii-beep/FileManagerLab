using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace FileManagerLab
{
    public abstract class Editor
    {
        protected string _content;
        protected string _path;
        public Editor(string content, string path)
        {
            this._content = content;
            this._path = path;
        }
        public abstract void Save();
        public abstract string Open();
    }

    public class TextEditor : Editor
    {
        public TextEditor(string content, string path) : base(content, path)
        { }

        public override void Save()
        {
            using(StreamWriter sw = new StreamWriter(_path))
            {
                sw.Write(_content);
            }
        }

        public override string Open()
        {
            string result = String.Empty;
            using(StreamReader sr = new StreamReader(_path))
            {
                result = sr.ReadToEnd();
            }
            return result;
        }
    }

    public class BinaryEditor : Editor
    {
        public BinaryEditor(string content, string path) : base(content, path)
        { }

        public override void Save()
        {
            using(BinaryWriter bw = new BinaryWriter(File.Open(_path, FileMode.OpenOrCreate)))
            {
                string[] words = _content.Split();
                foreach(var word in words)
                {
                    bw.Write(word);
                }                
            }
        }

        public override string Open()
        {
            StringBuilder sb = new StringBuilder();
            using(BinaryReader br = new BinaryReader(File.Open(_path, FileMode.OpenOrCreate)))
            {
                while(br.BaseStream.Position != br.BaseStream.Length)
                {
                    sb.Append(br.ReadChar());
                }
            }
            return sb.ToString();
        }
    }

    public abstract class Creator
    {
        public abstract Editor Create(string ext, string content, string path);
    }

    public class EditorCreator : Creator
    {
        public override Editor Create(string ext, string content, string path)
        {
            switch (ext)
            {
                case ".txt":
                    return new TextEditor(content, path);
                case ".dat":
                    return new BinaryEditor(content, path);
                default:
                    throw new ArgumentException("Invalid extension");
            }
        }
    }
}
