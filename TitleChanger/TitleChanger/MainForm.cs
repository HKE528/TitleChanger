using System;
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
            tvPath.Enabled = false;
            btnFindPath.Enabled = false;
        }

        private void isDirectory(string path)
        {
            commonPath = path;

            dirInfo = new DirectoryInfo(path);

            foreach (FileInfo file in dirInfo.GetFiles())
            {
                var fileName = file.Name;
                files.Add(fileName);
            }
        }

        private void notDirectory(string[] paths)
        {
            string path = paths[0];
            string[] splitPath = path.Split('\\');

            for (int i = 0; i < splitPath.Length - 1; i++)
            {
                commonPath += splitPath[i] + '\\';
            }
            commonPath = commonPath.Substring(0, commonPath.Length - 1);

            foreach (string file in paths)
            {
                var fileName = file.Split('\\').Last();
                files.Add(fileName);
            }
        }

        private bool isEqExtension(string ext)
        {
            foreach (string file in files)
            {
                if (ext != file.Split('.').Last())
                    return false;
            }

            return true;
        }

        private void refreshList()
        {
            fileListView.Items.Clear();
            files.Clear();
            commonPath = "";
            extension = "";
        }

        private void fileListView_DragDrop(object sender, DragEventArgs e)
        {
            refreshList();

            filesPath = (string[])e.Data.GetData(DataFormats.FileDrop);

            //폴더일때
            if (Directory.Exists(filesPath[0]))
            {
                isDirectory(filesPath[0]);
            }
            else
            {
                notDirectory(filesPath);
            }

            bool eqExtension = isEqExtension(files[0].Split('.').Last());
            extension = "." + files[0].Split('.').Last();

            if (eqExtension)
            {
                foreach (string file in files)
                {
                    fileListView.Items.Add(file);
                }
            }
            else
            {
                MessageBox.Show("파일들의 확장자가 서로 다릅니다.", "확장자 경고!!");
            }
        }

        private void fileListView_DragEnter(object sender, DragEventArgs e)
        {
            //드래그시 커서 모양 변경
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string newFileName = tbSetTitle.Text;
            if (!checkExist())
            {
                MessageBox.Show("파일이 존재하지 않습니다.", "경고!!");
                return;
            }

            if (cbDiffSaveName.Checked)
            {
                //다른이름으로 저장
            }
            else
            {
                //기존파일 바꾸기
                transFile(newFileName);
            }

            MessageBox.Show("파일 변환이 완료되었습니다.!!");
            refreshList()
        }

        private void transFile(string newFileName)
        {
            for (int i = 1; i <= files.Count(); i++)
            {
                string numbering = String.Format(" - {0:D2}", i);
                string newPath = commonPath + "\\" + newFileName + numbering + extension;
                string oldPath = commonPath + '\\' + files[i - 1];

                File.Move(oldPath, newPath);
            }
        }

        private bool checkExist()
        {
            for (int i = 0; i < files.Count(); i++)
            {
                string file = commonPath + '\\' + files[i];

                Console.WriteLine(file);

                if (!File.Exists(file))
                {
                    return false;
                }
            }

            return true;
        }

        private void cbDiffSaveName_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDiffSaveName.Checked)
            {
                tvPath.Enabled = true;
                btnFindPath.Enabled = true;
            }
            else
            {
                tvPath.Enabled = false;
                btnFindPath.Enabled = false;
            }
        }

        private void btnFindPath_Click(object sender, EventArgs e)
        {

        }
    } 
}
