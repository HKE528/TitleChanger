﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitleChanger
{
    public partial class MainPanel : Form
    {
        private string[] filesPath;
        private string commonPath;
        private string extension;
        private List<string> files = new List<string>();
        private DirectoryInfo dirInfo;

        public MainPanel()
        {
            InitializeComponent();
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {

        }

        private void fileListView_DragDrop(object sender, DragEventArgs e)
        {
            fileListView.Items.Clear();
            files.Clear();

            filesPath = (string[])e.Data.GetData(DataFormats.FileDrop);

            //폴더일때
            if(Directory.Exists(filesPath[0]))
            {
                commonPath = filesPath[0];

                dirInfo = new DirectoryInfo(filesPath[0]);

                foreach(FileInfo file in dirInfo.GetFiles())
                {
                    var fileName = file.Name;
                    files.Add(fileName);
                }
            }
            else
            {
                string[] splitPath = filesPath[0].Split('\\');
                for(int i = 0; i < splitPath.Length - 1; i ++)
                {
                    commonPath += splitPath[i] + '\\';
                }
                commonPath = commonPath.Substring(0, commonPath.Length - 1);

                foreach (string file in filesPath)
                {
                    var fileName = file.Split('\\').Last();
                    files.Add(fileName);
                }
            }

            foreach (string file in files)
            {
                fileListView.Items.Add(file);
            }

            Console.WriteLine(commonPath);
        }

        private void fileListView_DragEnter(object sender, DragEventArgs e)
        {
            //드래그시 커서 모양 변경
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
    }
}
