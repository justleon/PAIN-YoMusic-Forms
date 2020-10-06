using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAIN_YoMusic_Forms
{
    public partial class MainForm : Form
    {
        public List<SongListForm> viewList = new List<SongListForm>();
        public List<Song> songList = new List<Song>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SongListForm initView = new SongListForm(this, songList);
            initView.MdiParent = this;
            viewList.Add(initView);
            initView.Show();
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void optionNew_Click(object sender, EventArgs e)
        {
            SongListForm newMdiWindow = new SongListForm(this, songList);
            newMdiWindow.MdiParent = this;
            viewList.Add(newMdiWindow);
            newMdiWindow.Show();
        }

        private void optionTileHorizontally_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
