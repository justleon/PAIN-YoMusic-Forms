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
        private Document Document;

        public SongListForm(Document document)
        {
            InitializeComponent();
            Document = document;

            document.AddSongToList += AddSongToTheView;
            document.DeleteSongFromList += DeleteSongFromTheView;
            document.ModifySongOnList += ModifySongOnList;
        }

        private void SongListForm_Load(object sender, EventArgs e)
        {
            if (Document.GetSongList().Count != 0)
                UpdateList();
        }

        public void AddSongToTheView(Song song)
        {
            if (!SongFilter(song)) return;
            UpdateList();
            UpdateToolStripLabel();
        }

        public void DeleteSongFromTheView(Song song)
        {
            foreach (ListViewItem item in listView.Items)
            {
                if (item.Tag == song)
                {
                    listView.Items.Remove(item);
                    UpdateToolStripLabel();
                    return;
                }
            }
        }

        public void ModifySongOnList(Song song)
        {
            foreach(ListViewItem item in listView.Items)
            {
                if (item.Tag == song)
                {
                    if (!SongFilter(song))
                    {
                        listView.Items.Remove(item);
                        UpdateToolStripLabel();
                    }
                    else
                    {
                        item.SubItems[0].Text = song.title;
                        item.SubItems[1].Text = song.author;
                        item.SubItems[2].Text = song.dateTime.ToShortDateString();
                        item.SubItems[3].Text = song.category.ToString();
                    }
                    return;
                }
            }

            if (SongFilter(song))
            {
                UpdateList();
                UpdateToolStripLabel();
            }
        }

        private void UpdateList()
        {
            listView.Items.Clear();
            foreach(Song song in Filter(Document.GetSongList()))
            {
                ListViewItem viewItem = new ListViewItem();
                viewItem.Tag = song;
                UpdateItem(viewItem);
                listView.Items.Add(viewItem);
            }
            UpdateToolStripLabel();
        }

        private void UpdateItem(ListViewItem item)
        {
            Song song = (Song)item.Tag;
            while (item.SubItems.Count < 4)
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[0].Text = song.title;
            item.SubItems[1].Text = song.author;
            item.SubItems[2].Text = song.dateTime.ToShortDateString();
            item.SubItems[3].Text = song.category.ToString();
        }

        private void UpdateToolStripLabel()
        {
            toolStripStatusLabel.Text = "Elements: " + listView.Items.Count;
        }

        private bool SongFilter(Song song)
        {
            switch (toolStripFilter.Text)
            {
                case "Before 2000":
                    return song.dateTime.Year < 2000;
                case "After 2000":
                    return song.dateTime.Year >= 2000;
                default:
                    return true;
            }
        }

        private List<Song> Filter(List<Song> songList)
        {
            return songList.Where(SongFilter).ToList();
        }

        private void SongListForm_Activated(object sender, EventArgs e)
        {
            ToolStripManager.Merge(statusStrip, ((MainForm)MdiParent).statusStrip);
            ToolStripManager.Merge(toolStrip, ((MainForm)MdiParent).toolStripTop);
        }

        private void SongListForm_Deactivate(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(((MainForm)MdiParent).statusStrip, statusStrip);
            ToolStripManager.RevertMerge(((MainForm)MdiParent).toolStripTop, toolStrip);
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SongManagerForm manageSongForm = new SongManagerForm(null);
            if(manageSongForm.ShowDialog() == DialogResult.OK)
            {
                Song newSong = new Song(manageSongForm.GetTitle(), manageSongForm.GetAuthor(), manageSongForm.GetDate(), manageSongForm.GetCategory());
                Document.AddSong(newSong);
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item from the list view?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Song selectedItem = (Song)listView.SelectedItems[0].Tag;
                Document.DeleteSong(selectedItem);

                MessageBox.Show("Successfully removed \"" + selectedItem.title + "\" from the list!", "Success");
            }
        }

        private void ModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Song modifiedItem = (Song)listView.SelectedItems[0].Tag;
            SongManagerForm manageSongForm = new SongManagerForm(modifiedItem);

            if (manageSongForm.ShowDialog() == DialogResult.OK)
            {
                modifiedItem.title = manageSongForm.GetTitle();
                modifiedItem.author = manageSongForm.GetAuthor();
                modifiedItem.dateTime = manageSongForm.GetDate();
                modifiedItem.category = manageSongForm.GetCategory();
                Document.UpdateSong(modifiedItem);
            }
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                deleteToolStripMenuItem.Enabled = modifyToolStripMenuItem.Enabled = false;
                toolStripDeleteButton.Enabled = toolStripModifyButton.Enabled = false;
            }
            else
            {
                deleteToolStripMenuItem.Enabled = modifyToolStripMenuItem.Enabled = true;
                toolStripDeleteButton.Enabled = toolStripModifyButton.Enabled = true;
            }
        }

        private void ToolStripFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateList();
        }
    }
}
