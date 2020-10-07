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
    public partial class SongListForm : Form
    {
        MainForm mainForm;
        SongManagerForm manageSongForm;
        List<Song> songList;

        public SongListForm(MainForm mainForm, List<Song> songList)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.songList = songList.ConvertAll(song => new Song(song.title, song.author, song.dateTime, song.category)); //creates deep copy of the main song list
        }

        private void SongListForm_Load(object sender, EventArgs e)
        {
            if (songList.Count() != 0)
            {
                foreach (Song song in songList)
                {
                    string[] row = { song.title, song.author, song.dateTime, song.category };
                    ListViewItem viewItem = new ListViewItem(row);
                    viewItem.Tag = song;
                    listView.Items.Add(viewItem);
                }
            }
        }

        private void check_form_closure(object sender, FormClosingEventArgs e)
        {
            if (mainForm.GetOpenViews() <= 1 && e.CloseReason != CloseReason.MdiFormClosing)
                e.Cancel = true;
            else
                mainForm.RemoveView(sender as SongListForm);
        }

        private void SongListForm_Activated(object sender, EventArgs e)
        {
            this.menuStripList.AllowMerge = true;
            mainForm.toolStripStatusLabel.Text = "Elements: " + songList.Count.ToString();
        }

        private void SongListForm_Deactivate(object sender, EventArgs e)
        {
            this.menuStripList.AllowMerge = false;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageSongForm = new SongManagerForm(null);
            if(manageSongForm.ShowDialog() == DialogResult.OK)
            {
                Song newSong = new Song(manageSongForm.GetData());
                this.songList.Add(newSong);

                string[] row = { newSong.title, newSong.author, newSong.dateTime, newSong.category };
                ListViewItem viewItem = new ListViewItem(row);
                viewItem.Tag = newSong;
                listView.Items.Add(viewItem);
                mainForm.AddNewSongToList(newSong);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this item from the list?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];
                Song selectedSong = (Song)selectedItem.Tag;

                listView.Items.Remove(selectedItem);
                songList.Remove(selectedSong);

                MessageBox.Show("Successfully removed " + selectedSong.title + " from the list!", "Success");
            }
            
        }

        private void listView_ItemActivate(object sender, EventArgs e)
        {
            deleteToolStripMenuItem.Enabled = modifyToolStripMenuItem.Enabled = true;
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
                deleteToolStripMenuItem.Enabled = modifyToolStripMenuItem.Enabled = false;
        }
    }
}
