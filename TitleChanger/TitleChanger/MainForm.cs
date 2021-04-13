using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitleChanger
{
    public partial class MainPanel : Form
    {
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
