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
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        public void AddNewSongToList(Song song) { songList.Add(song); }
        public List<Song> GetSongList() { return songList; }
        public int GetOpenViews() { return viewList.Count; }
        public void UpdateToolStripLabel(int num) { toolStripStatusLabel.Text = "Elements: " + num;  }
        public void RemoveView(SongListForm songList) { viewList.Remove(songList); }

        public void UpdateExistingViews(Song song)
        {
            foreach(SongListForm listView in viewList)
            {
                listView.AddSongToTheView(song);
            }

            AddNewSongToList(song);
        }

        public void UpdateSongInViews(ListViewItem modifiedItem)
        {
            foreach(SongListForm listView in viewList)
            {
                listView.ModifySongOnList(modifiedItem);
            }
        }

        public void UpdateSongGlobally(ListViewItem modifiedItem)
        {
            foreach(Song song in songList)
            {
                if(song == modifiedItem.Tag)
                {
                    song.title = modifiedItem.SubItems[0].Text;
                    song.author = modifiedItem.SubItems[1].Text;
                    song.dateTime = modifiedItem.SubItems[2].Text;
                    song.category = modifiedItem.SubItems[3].Text;
                    break;
                }
            }
        }

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
                Close();
                Application.Exit();
            }
        }

        private void optionTileHorizontally_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void optionTileVertically_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}