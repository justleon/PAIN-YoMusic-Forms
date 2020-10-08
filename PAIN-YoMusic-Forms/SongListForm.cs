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

        public SongListForm(MainForm mainForm, List<Song> songList)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void SongListForm_Load(object sender, EventArgs e)
        {
            List<Song> songList = mainForm.GetSongList();
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

        public void AddSongToTheView(Song song)
        {
            string[] row = { song.title, song.author, song.dateTime, song.category };
            ListViewItem viewItem = new ListViewItem(row);
            viewItem.Tag = song;
            listView.Items.Add(viewItem);
        }

        public void ModifySongOnList(ListViewItem song)
        {
            foreach(ListViewItem item in listView.Items)
            {
                if(item.Tag == song.Tag)
                {
                    item.SubItems[0].Text = song.SubItems[0].Text;
                    item.SubItems[1].Text = song.SubItems[1].Text;
                    item.SubItems[2].Text = song.SubItems[2].Text;
                    item.SubItems[3].Text = song.SubItems[3].Text;
                    break;
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
            menuStripList.AllowMerge = true;
            mainForm.UpdateToolStripLabel(listView.Items.Count);
        }

        private void SongListForm_Deactivate(object sender, EventArgs e)
        {
            menuStripList.AllowMerge = false;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageSongForm = new SongManagerForm(null);
            if(manageSongForm.ShowDialog() == DialogResult.OK)
            {
                Song newSong = new Song(manageSongForm.GetData());
                mainForm.UpdateExistingViews(newSong);
                mainForm.UpdateToolStripLabel(listView.Items.Count);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this item from the list view?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];
                Song selectedSong = (Song)selectedItem.Tag;
                listView.Items.Remove(selectedItem);
                mainForm.UpdateToolStripLabel(listView.Items.Count);

                MessageBox.Show("Successfully removed \"" + selectedSong.title + "\" from the list!", "Success");
            }
            
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem modifiedItem = listView.SelectedItems[0];
            Song modifiedSong = (Song)modifiedItem.Tag;
            manageSongForm = new SongManagerForm(modifiedSong);

            if (manageSongForm.ShowDialog() == DialogResult.OK)
            {
                string[] newData = manageSongForm.GetData();
                modifiedItem.SubItems[0].Text = newData[0];
                modifiedItem.SubItems[1].Text = newData[1];
                modifiedItem.SubItems[2].Text = newData[2];
                modifiedItem.SubItems[3].Text = newData[3];
                mainForm.UpdateSongInViews(modifiedItem);
                mainForm.UpdateSongGlobally(modifiedItem);
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
