using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAIN_YoMusic_Forms
{
    public partial class SongListForm : Form
    {
        Document document;
        SongManagerForm manageSongForm;

        public SongListForm(Document document)
        {
            InitializeComponent();
            this.document = document;

            document.AddSongToList += AddSongToTheView;
            document.DeleteSongFromList += DeleteSongFromTheView;
            document.ModifySongOnList += ModifySongOnList;
        }

        private void SongListForm_Load(object sender, EventArgs e)
        {
            List<Song> songList = document.GetSongList();
            if (songList.Count() != 0)
                LoadWholeList();
        }

        public void AddSongToTheView(Song song)
        {
            string[] row = { song.title, song.author, song.dateTime, song.category };
            ListViewItem viewItem = new ListViewItem(row);
            viewItem.Tag = song;
            listView.Items.Add(viewItem);
            UpdateToolStripLabel(listView.Items.Count);
        }

        public void DeleteSongFromTheView(ListViewItem song)
        {
            foreach (ListViewItem item in listView.Items)
            {
                if (item.Tag == song.Tag)
                {
                    listView.Items.Remove(item);
                    break;
                }
            }
            UpdateToolStripLabel(listView.Items.Count);
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
            UpdateToolStripLabel(listView.Items.Count);
        }

        public void LoadWholeList()
        {
            foreach (Song song in document.GetSongList())
            {
                string[] row = { song.title, song.author, song.dateTime, song.category };
                ListViewItem viewItem = new ListViewItem(row);
                viewItem.Tag = song;
                listView.Items.Add(viewItem);
            }
            UpdateToolStripLabel(listView.Items.Count);
        }

        public void LoadFilteredList(bool beforeDate)
        {
            foreach(Song song in document.GetSongList())
            {
                var date = DateTime.Parse(song.dateTime);

                if ((date.Year < 2000 && beforeDate == false) || (date.Year >= 2000 && beforeDate))
                    continue;

                string[] row = { song.title, song.author, song.dateTime, song.category };
                ListViewItem viewItem = new ListViewItem(row);
                viewItem.Tag = song;
                listView.Items.Add(viewItem);
            }
            UpdateToolStripLabel(listView.Items.Count);
        }

        public void UpdateToolStripLabel(int num)
        {
            toolStripStatusLabel.Text = "Elements: " + num;
        }

        private void SongListForm_Activated(object sender, EventArgs e)
        {
            menuStripList.AllowMerge = statusStripList.AllowMerge = true;
        }

        private void SongListForm_Deactivate(object sender, EventArgs e)
        {
            menuStripList.AllowMerge = statusStripList.AllowMerge = false;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageSongForm = new SongManagerForm(null);
            if(manageSongForm.ShowDialog() == DialogResult.OK)
            {
                Song newSong = new Song(manageSongForm.GetData());
                document.AddSong(newSong);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item from the list view?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];
                document.DeleteSong(selectedItem);

                MessageBox.Show("Successfully removed \"" + selectedItem.SubItems[0].Text + "\" from the list!", "Success");
            }
            
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem modifiedItem = listView.SelectedItems[0];
            manageSongForm = new SongManagerForm((Song)modifiedItem.Tag);

            if (manageSongForm.ShowDialog() == DialogResult.OK)
            {
                string[] newData = manageSongForm.GetData();
                modifiedItem.SubItems[0].Text = newData[0];
                modifiedItem.SubItems[1].Text = newData[1];
                modifiedItem.SubItems[2].Text = newData[2];
                modifiedItem.SubItems[3].Text = newData[3];
                document.UpdateSong(modifiedItem);
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

        private void afterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afterToolStripMenuItem.Checked = (afterToolStripMenuItem.Checked) ? false : true;

            if (beforeToolStripMenuItem.Checked)
                beforeToolStripMenuItem.CheckState = CheckState.Unchecked;

            listView.Items.Clear();
            if (!afterToolStripMenuItem.Checked && !beforeToolStripMenuItem.Checked)
            {
                LoadWholeList();
            }
            else
            {
                LoadFilteredList(false);
            }
        }

        private void beforeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            beforeToolStripMenuItem.Checked = (beforeToolStripMenuItem.Checked) ? false : true;

            if (afterToolStripMenuItem.Checked)
                afterToolStripMenuItem.CheckState = CheckState.Unchecked;

            listView.Items.Clear();
            if (!afterToolStripMenuItem.Checked && !beforeToolStripMenuItem.Checked)
            {
                LoadWholeList();
            }
            else
            {
                LoadFilteredList(true);
            }
        }
    }
}
