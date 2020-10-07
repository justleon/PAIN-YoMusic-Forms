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
        private List<SongListForm> viewList = new List<SongListForm>();
        private List<Song> songList = new List<Song>();

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

        public void AddNewSongToList(Song song) { songList.Add(song); }

        public int GetOpenViews() { return this.viewList.Count; }
        
        public void RemoveView(SongListForm songList) { this.viewList.Remove(songList); }

        private void optionNew_Click(object sender, EventArgs e)
        {
            SongListForm newMdiWindow = new SongListForm(this, songList);
            newMdiWindow.MdiParent = this;
            viewList.Add(newMdiWindow);
            newMdiWindow.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit the program?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void optionTileHorizontally_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void optionTileVertically_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
